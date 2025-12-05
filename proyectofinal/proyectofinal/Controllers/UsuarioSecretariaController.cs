using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace proyectofinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioSecretariaController : ControllerBase
    {
        private readonly string _connString = "Server=(localdb)\\MSSQLLocalDB;Database=db_proyectofinal;Trusted_Connection=True;";

        public class RegistroDto { public string email { get; set; } = string.Empty; public string password { get; set; } = string.Empty; }
        public class DatosSecretariaDto
        {
            public int idSecretaria { get; set; }
            public string nombre { get; set; } = string.Empty;
            public string apellido { get; set; } = string.Empty;
            public string dui { get; set; } = string.Empty;
            public DateTime fecha { get; set; }
            public string telefono { get; set; } = string.Empty;
            public string direccion { get; set; } = string.Empty;
            public string? especialidad { get; set; }
            public string? correo { get; set; }
        }
        public class CredencialesDto { public string email { get; set; } = string.Empty; public string password { get; set; } = string.Empty; }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] RegistroDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.email) || string.IsNullOrWhiteSpace(dto.password))
                return BadRequest(new { mensaje = "Email y password son obligatorios." });
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                using (var cmdCheck = new SqlCommand("SELECT COUNT(1) FROM dbo.UsuarioSecretaria WHERE password=@password", con))
                {
                    cmdCheck.Parameters.AddWithValue("@password", dto.password);
                    if ((int)await cmdCheck.ExecuteScalarAsync() >0)
                    {
                        var sugerencias = new List<string>();
                        var rnd = new Random();
                        while (sugerencias.Count <3)
                        {
                            var candidate = $"Sec{rnd.Next(100000,999999)}";
                            using var cmdSug = new SqlCommand("SELECT COUNT(1) FROM dbo.UsuarioSecretaria WHERE password=@pwd", con);
                            cmdSug.Parameters.AddWithValue("@pwd", candidate);
                            if ((int)await cmdSug.ExecuteScalarAsync() ==0 && !sugerencias.Contains(candidate))
                                sugerencias.Add(candidate);
                        }
                        return Conflict(new { mensaje = "la contraseña ya existe", sugerencias });
                    }
                }
                using (var cmdInsert = new SqlCommand("INSERT INTO dbo.UsuarioSecretaria (email,password) OUTPUT INSERTED.idSecretaria VALUES (@email,@password)", con))
                {
                    cmdInsert.Parameters.AddWithValue("@email", dto.email);
                    cmdInsert.Parameters.AddWithValue("@password", dto.password);
                    var newId = (int)(await cmdInsert.ExecuteScalarAsync() ??0);
                    return Ok(new { idSecretaria = newId, email = dto.email });
                }
            }
            catch (Exception ex) { return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message }); }
        }

        private async Task<(bool identity, HashSet<string> cols, Dictionary<string, int> lengths, FotoMeta fotoMeta)> ObtenerInfoTabla(SqlConnection con)
        {
            var cols = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var lengths = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (var cmdCols = new SqlCommand("SELECT COLUMN_NAME, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='DatosSecretaria'", con))
            using (var reader = await cmdCols.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    var c = reader.GetString(0);
                    cols.Add(c);
                    if (!reader.IsDBNull(1)) lengths[c] = reader.GetInt32(1);
                }
            }
            bool identity = false;
            using (var cmdIdent = new SqlCommand("SELECT c.is_identity FROM sys.columns c WHERE c.object_id=OBJECT_ID('dbo.DatosSecretaria') AND c.name='idSecretaria'", con))
            {
                var r = await cmdIdent.ExecuteScalarAsync();
                if (r != null && r != DBNull.Value) identity = Convert.ToInt32(r) ==1;
            }
            // Foto column meta (type + max_length bytes)
            var fotoMeta = new FotoMeta();
            using (var cmdFoto = new SqlCommand("SELECT t.name, c.max_length FROM sys.columns c JOIN sys.types t ON c.user_type_id=t.user_type_id WHERE c.object_id=OBJECT_ID('dbo.DatosSecretaria') AND c.name='foto'", con))
            {
                using var fr = await cmdFoto.ExecuteReaderAsync();
                if (await fr.ReadAsync())
                {
                    fotoMeta.Exists = true;
                    fotoMeta.DataType = fr.GetString(0);
                    fotoMeta.MaxLengthBytes = fr.GetInt16(1); // smallint in sys.columns
                }
            }
            return (identity, cols, lengths, fotoMeta);
        }

        private string Recortar(string valor, Dictionary<string, int> lengths, string col)
        {
            if (valor == null) return string.Empty;
            if (lengths.TryGetValue(col, out var max) && max >0 && valor.Length > max)
                return valor.Substring(0, max);
            return valor;
        }

        private class FotoMeta
        {
            public bool Exists { get; set; }
            public string DataType { get; set; } = string.Empty; // varbinary / nvarchar / varchar etc.
            public int MaxLengthBytes { get; set; } // -1 indica MAX para tipos varbinary(max), nvarchar(max)
        }

        [HttpPost("guardarDatos")]
        public async Task<IActionResult> GuardarDatos([FromBody] DatosSecretariaDto dto)
        {
            if (dto.idSecretaria <=0) return BadRequest(new { mensaje = "idSecretaria inválido." });
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                using (var cmdUser = new SqlCommand("SELECT COUNT(1) FROM dbo.UsuarioSecretaria WHERE idSecretaria=@id", con))
                { cmdUser.Parameters.AddWithValue("@id", dto.idSecretaria); if ((int)await cmdUser.ExecuteScalarAsync() ==0) return BadRequest(new { mensaje = "El usuario no existe." }); }
                using (var cmdDup = new SqlCommand("SELECT COUNT(1) FROM dbo.DatosSecretaria WHERE idSecretaria=@id", con))
                { cmdDup.Parameters.AddWithValue("@id", dto.idSecretaria); if ((int)await cmdDup.ExecuteScalarAsync() >0) return Conflict(new { mensaje = "Este usuario ya tiene datos registrados." }); }

                var info = await ObtenerInfoTabla(con);
                var identity = info.identity; var cols = info.cols; var len = info.lengths;

                var nombre = Recortar(dto.nombre, len, "nombre");
                var apellido = Recortar(dto.apellido, len, "apellido");
                var dui = Recortar(dto.dui, len, "dui");
                var especialidad = Recortar(dto.especialidad ?? "N/A", len, "especialidad");
                var telefono = Recortar(dto.telefono, len, "telefono");
                var correo = Recortar(dto.correo ?? string.Empty, len, "correo");
                var direccion = Recortar(dto.direccion, len, "direccion");

                var columnas = new List<string> { "idSecretaria" };
                var valores = new List<string> { "@id" };
                if (cols.Contains("nombre")) { columnas.Add("nombre"); valores.Add("@nombre"); }
                if (cols.Contains("apellido")) { columnas.Add("apellido"); valores.Add("@apellido"); }
                if (cols.Contains("dui")) { columnas.Add("dui"); valores.Add("@dui"); }
                if (cols.Contains("especialidad")) { columnas.Add("especialidad"); valores.Add("@especialidad"); }
                if (cols.Contains("telefono")) { columnas.Add("telefono"); valores.Add("@telefono"); }
                if (cols.Contains("fecha")) { columnas.Add("fecha"); valores.Add("@fecha"); }
                if (cols.Contains("correo")) { columnas.Add("correo"); valores.Add("@correo"); }
                if (cols.Contains("direccion")) { columnas.Add("direccion"); valores.Add("@direccion"); }

                var sql = $"INSERT INTO dbo.DatosSecretaria ({string.Join(",", columnas)}) VALUES ({string.Join(",", valores)})";
                if (identity)
                {
                    using var on = new SqlCommand("SET IDENTITY_INSERT dbo.DatosSecretaria ON;", con);
                    await on.ExecuteNonQueryAsync();
                }
                using (var cmdIns = new SqlCommand(sql, con))
                {
                    cmdIns.Parameters.AddWithValue("@id", dto.idSecretaria);
                    if (cols.Contains("nombre")) cmdIns.Parameters.AddWithValue("@nombre", nombre);
                    if (cols.Contains("apellido")) cmdIns.Parameters.AddWithValue("@apellido", apellido);
                    if (cols.Contains("dui")) cmdIns.Parameters.AddWithValue("@dui", dui);
                    if (cols.Contains("especialidad")) cmdIns.Parameters.AddWithValue("@especialidad", especialidad);
                    if (cols.Contains("telefono")) cmdIns.Parameters.AddWithValue("@telefono", telefono);
                    if (cols.Contains("fecha")) cmdIns.Parameters.AddWithValue("@fecha", dto.fecha);
                    if (cols.Contains("correo")) cmdIns.Parameters.AddWithValue("@correo", correo);
                    if (cols.Contains("direccion")) cmdIns.Parameters.AddWithValue("@direccion", direccion);
                    await cmdIns.ExecuteNonQueryAsync();
                }
                if (identity)
                {
                    using var off = new SqlCommand("SET IDENTITY_INSERT dbo.DatosSecretaria OFF;", con);
                    await off.ExecuteNonQueryAsync();
                }
                return Ok(new { mensaje = "Datos guardados" });
            }
            catch (Exception ex) { return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message }); }
        }

        [HttpPost("guardarDatosConFoto")]
        [RequestSizeLimit(10_000_000)]
        public async Task<IActionResult> GuardarDatosConFoto(
            [FromForm] int idSecretaria,
            [FromForm] string nombre,
            [FromForm] string apellido,
            [FromForm] string dui,
            [FromForm] string fecha,
            [FromForm] string telefono,
            [FromForm] string direccion,
            [FromForm] IFormFile? foto,
            [FromForm] string? especialidad,
            [FromForm] string? correo)
        {
            if (idSecretaria <=0) return BadRequest(new { mensaje = "idSecretaria inválido." });
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dui) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(direccion))
                return BadRequest(new { mensaje = "Todos los campos son obligatorios." });
            DateTime? fechaDt = null;
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                using (var cmdUser = new SqlCommand("SELECT COUNT(1) FROM dbo.UsuarioSecretaria WHERE idSecretaria=@id", con))
                { cmdUser.Parameters.AddWithValue("@id", idSecretaria); if ((int)await cmdUser.ExecuteScalarAsync() ==0) return BadRequest(new { mensaje = "El usuario no existe." }); }
                using (var cmdDup = new SqlCommand("SELECT COUNT(1) FROM dbo.DatosSecretaria WHERE idSecretaria=@id", con))
                { cmdDup.Parameters.AddWithValue("@id", idSecretaria); if ((int)await cmdDup.ExecuteScalarAsync() >0) return Conflict(new { mensaje = "Este usuario ya tiene datos registrados." }); }

                var info = await ObtenerInfoTabla(con);
                var identity = info.identity; var cols = info.cols; var len = info.lengths; var fotoMeta = info.fotoMeta;

                if (cols.Contains("fecha"))
                {
                    if (string.IsNullOrWhiteSpace(fecha)) return BadRequest(new { mensaje = "La fecha es obligatoria." });
                    if (!DateTime.TryParseExact(fecha, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fd))
                        return BadRequest(new { mensaje = "Formato de fecha inválido. Usa yyyy-MM-dd." });
                    fechaDt = fd;
                }

                // Recortes
                nombre = Recortar(nombre, len, "nombre");
                apellido = Recortar(apellido, len, "apellido");
                dui = Recortar(dui, len, "dui");
                var espValor = Recortar(especialidad ?? "N/A", len, "especialidad");
                telefono = Recortar(telefono, len, "telefono");
                var correoValor = Recortar(correo ?? string.Empty, len, "correo");
                direccion = Recortar(direccion, len, "direccion");

                string? fotoRutaGuardada = null; byte[]? fotoBytes = null; string? fotoTexto = null;
                if (foto != null && foto.Length >0 && (cols.Contains("fotoRuta") || fotoMeta.Exists))
                {
                    var uploadsRoot = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "secretarias");
                    Directory.CreateDirectory(uploadsRoot);
                    var ext = Path.GetExtension(foto.FileName); if (string.IsNullOrWhiteSpace(ext)) ext = ".jpg";
                    var fileName = $"{idSecretaria}{ext}";
                    var fullPath = Path.Combine(uploadsRoot, fileName);
                    using (var fs = new FileStream(fullPath, FileMode.Create)) { await foto.CopyToAsync(fs); }
                    fotoRutaGuardada = $"/uploads/secretarias/{fileName}";

                    // Manejo 'foto' -> si es varbinary y cabe; si es texto guardar solo nombre
                    if (fotoMeta.Exists)
                    {
                        if (fotoMeta.DataType.Equals("varbinary", StringComparison.OrdinalIgnoreCase) || fotoMeta.DataType.Equals("image", StringComparison.OrdinalIgnoreCase))
                        {
                            using var ms = new MemoryStream();
                            await foto.OpenReadStream().CopyToAsync(ms);
                            var bytes = ms.ToArray();
                            // max_length -1 => MAX (sin límite práctico aquí). Si límite y excede, no se inserta para evitar truncación.
                            if (fotoMeta.MaxLengthBytes == -1 || bytes.Length <= fotoMeta.MaxLengthBytes)
                                fotoBytes = bytes;
                        }
                        else // es tipo texto (nvarchar/varchar) => almacenar nombre de archivo recortado
                        {
                            fotoTexto = fileName;
                            // Recortar si existe longitud en lengths (character maximum length) para 'foto'
                            if (len.TryGetValue("foto", out var strMax) && strMax >0 && fotoTexto.Length > strMax)
                                fotoTexto = fotoTexto.Substring(0, strMax);
                        }
                    }
                }

                var columnas = new List<string> { "idSecretaria", "nombre", "apellido", "dui", "telefono", "direccion" };
                var valores = new List<string> { "@id", "@nombre", "@apellido", "@dui", "@telefono", "@direccion" };
                if (cols.Contains("especialidad")) { columnas.Add("especialidad"); valores.Add("@especialidad"); }
                if (cols.Contains("fecha")) { columnas.Add("fecha"); valores.Add("@fecha"); }
                if (cols.Contains("correo")) { columnas.Add("correo"); valores.Add("@correo"); }
                if (cols.Contains("fotoRuta") && fotoRutaGuardada != null) { columnas.Add("fotoRuta"); valores.Add("@fotoRuta"); }
                if (fotoMeta.Exists && (fotoBytes != null || fotoTexto != null)) { columnas.Add("foto"); valores.Add("@foto"); }

                var sql = $"INSERT INTO dbo.DatosSecretaria ({string.Join(",", columnas)}) VALUES ({string.Join(",", valores)})";
                if (identity)
                {
                    using var on = new SqlCommand("SET IDENTITY_INSERT dbo.DatosSecretaria ON;", con);
                    await on.ExecuteNonQueryAsync();
                }
                using (var cmdIns = new SqlCommand(sql, con))
                {
                    cmdIns.Parameters.AddWithValue("@id", idSecretaria);
                    cmdIns.Parameters.AddWithValue("@nombre", nombre);
                    cmdIns.Parameters.AddWithValue("@apellido", apellido);
                    cmdIns.Parameters.AddWithValue("@dui", dui);
                    cmdIns.Parameters.AddWithValue("@telefono", telefono);
                    cmdIns.Parameters.AddWithValue("@direccion", direccion);
                    if (cols.Contains("especialidad")) cmdIns.Parameters.AddWithValue("@especialidad", espValor);
                    if (cols.Contains("fecha") && fechaDt.HasValue) cmdIns.Parameters.AddWithValue("@fecha", fechaDt.Value);
                    if (cols.Contains("correo")) cmdIns.Parameters.AddWithValue("@correo", correoValor);
                    if (cols.Contains("fotoRuta") && fotoRutaGuardada != null) cmdIns.Parameters.AddWithValue("@fotoRuta", fotoRutaGuardada);
                    if (fotoMeta.Exists && (fotoBytes != null || fotoTexto != null))
                    {
                        if (fotoBytes != null)
                            cmdIns.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary, fotoBytes.Length).Value = fotoBytes;
                        else
                            cmdIns.Parameters.AddWithValue("@foto", fotoTexto ?? string.Empty);
                    }
                    await cmdIns.ExecuteNonQueryAsync();
                }
                if (identity)
                {
                    using var off = new SqlCommand("SET IDENTITY_INSERT dbo.DatosSecretaria OFF;", con);
                    await off.ExecuteNonQueryAsync();
                }
                return Ok(new { mensaje = "Datos guardados", fotoRuta = fotoRutaGuardada });
            }
            catch (Exception ex) { return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message }); }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] CredencialesDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.email) || string.IsNullOrWhiteSpace(dto.password))
                return BadRequest(new { mensaje = "Email y password son obligatorios." });
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                using var cmd = new SqlCommand("SELECT TOP(1) idSecretaria,password FROM dbo.UsuarioSecretaria WHERE email=@e", con);
                cmd.Parameters.AddWithValue("@e", dto.email);
                using var reader = await cmd.ExecuteReaderAsync();
                if (!await reader.ReadAsync()) return Ok(new { valido = false, error = "email" });
                var idSec = reader.GetInt32(0); var passDb = reader.GetString(1);
                if (!string.Equals(passDb, dto.password)) return Ok(new { valido = false, error = "password" });
                return Ok(new { valido = true, idSecretaria = idSec });
            }
            catch (Exception ex) { return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message }); }
        }

        [HttpPost("guardarDatosSimple")]
        public async Task<IActionResult> GuardarDatosSimple([FromBody] DatosSecretariaDto dto)
        {
            if (dto.idSecretaria <=0) return BadRequest(new { mensaje = "idSecretaria inválido" });
            if (string.IsNullOrWhiteSpace(dto.nombre) || string.IsNullOrWhiteSpace(dto.apellido) || string.IsNullOrWhiteSpace(dto.dui) || string.IsNullOrWhiteSpace(dto.telefono) || string.IsNullOrWhiteSpace(dto.direccion) || dto.fecha == default)
                return BadRequest(new { mensaje = "Campos obligatorios faltan" });
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                // Verificar usuario
                using (var cmdUser = new SqlCommand("SELECT COUNT(1) FROM dbo.UsuarioSecretaria WHERE idSecretaria=@id", con))
                { cmdUser.Parameters.AddWithValue("@id", dto.idSecretaria); if ((int)await cmdUser.ExecuteScalarAsync() ==0) return BadRequest(new { mensaje = "Usuario no existe" }); }
                // Evitar duplicado
                using (var cmdDup = new SqlCommand("SELECT COUNT(1) FROM dbo.DatosSecretaria WHERE idSecretaria=@id", con))
                { cmdDup.Parameters.AddWithValue("@id", dto.idSecretaria); if ((int)await cmdDup.ExecuteScalarAsync() >0) return Conflict(new { mensaje = "Ya tiene datos" }); }
                // Insert fijo (sin foto)
                var sql = @"INSERT INTO dbo.DatosSecretaria (idSecretaria,nombre,apellido,dui,especialidad,telefono,fecha,correo,direccion)
                            VALUES (@id,@nombre,@apellido,@dui,@especialidad,@telefono,@fecha,@correo,@direccion)";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", dto.idSecretaria);
                    cmd.Parameters.AddWithValue("@nombre", dto.nombre);
                    cmd.Parameters.AddWithValue("@apellido", dto.apellido);
                    cmd.Parameters.AddWithValue("@dui", dto.dui);
                    cmd.Parameters.AddWithValue("@especialidad", (object?)dto.especialidad ?? "N/A");
                    cmd.Parameters.AddWithValue("@telefono", dto.telefono);
                    cmd.Parameters.AddWithValue("@fecha", dto.fecha);
                    cmd.Parameters.AddWithValue("@correo", (object?)dto.correo ?? "");
                    cmd.Parameters.AddWithValue("@direccion", dto.direccion);
                    await cmd.ExecuteNonQueryAsync();
                }
                return Ok(new { mensaje = "Datos guardados" });
            }
            catch (Exception ex) { return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message }); }
        }

        [HttpPost("subirFoto")]
        public async Task<IActionResult> SubirFoto([FromForm] int idSecretaria, [FromForm] IFormFile foto)
        {
            if (idSecretaria <=0) return BadRequest(new { mensaje = "id inválido" });
            if (foto == null || foto.Length ==0) return BadRequest(new { mensaje = "Sin archivo" });
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                using (var cmdUser = new SqlCommand("SELECT COUNT(1) FROM dbo.DatosSecretaria WHERE idSecretaria=@id", con))
                { cmdUser.Parameters.AddWithValue("@id", idSecretaria); if ((int)await cmdUser.ExecuteScalarAsync() ==0) return NotFound(new { mensaje = "Datos no existen" }); }
                // Guardar en disco
                var uploadsRoot = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "secretarias");
                Directory.CreateDirectory(uploadsRoot);
                var ext = Path.GetExtension(foto.FileName); if (string.IsNullOrWhiteSpace(ext)) ext = ".jpg";
                var fileName = idSecretaria + ext;
                var fullPath = Path.Combine(uploadsRoot, fileName);
                using (var fs = new FileStream(fullPath, FileMode.Create)) { await foto.CopyToAsync(fs); }
                var ruta = "/uploads/secretarias/" + fileName;
                // Actualizar si existe la columna fotoRuta
                using (var cmdHas = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='DatosSecretaria' AND COLUMN_NAME='fotoRuta'", con))
                {
                    if ((int)await cmdHas.ExecuteScalarAsync() ==1)
                    {
                        using var cmdUpd = new SqlCommand("UPDATE dbo.DatosSecretaria SET fotoRuta=@r WHERE idSecretaria=@id", con);
                        cmdUpd.Parameters.AddWithValue("@r", ruta);
                        cmdUpd.Parameters.AddWithValue("@id", idSecretaria);
                        await cmdUpd.ExecuteNonQueryAsync();
                    }
                }
                return Ok(new { mensaje = "Foto guardada", ruta });
            }
            catch (Exception ex) { return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message }); }
        }

        // Nuevo endpoint para obtener datos de la secretaria y mostrar en perfil administrativo
        [HttpGet("obtenerDatosSecretaria/{id}")]
        public async Task<IActionResult> ObtenerDatosSecretaria(int id)
        {
            if (id <=0) return BadRequest(new { mensaje = "Id inválido" });
            try
            {
                using var con = new SqlConnection(_connString);
                await con.OpenAsync();
                using var cmd = new SqlCommand(@"SELECT TOP(1) idSecretaria,nombre,apellido,dui,especialidad,telefono,fecha,correo,direccion,fotoRuta FROM dbo.DatosSecretaria WHERE idSecretaria=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = await cmd.ExecuteReaderAsync();
                if (!await reader.ReadAsync()) return NotFound(new { mensaje = "No hay datos" });
                var resp = new Dictionary<string, object?>
                {
                    ["idSecretaria"] = reader.GetInt32(0),
                    ["nombre"] = reader.IsDBNull(1) ? null : reader.GetString(1),
                    ["apellido"] = reader.IsDBNull(2) ? null : reader.GetString(2),
                    ["dui"] = reader.IsDBNull(3) ? null : reader.GetString(3),
                    ["especialidad"] = reader.IsDBNull(4) ? null : reader.GetString(4),
                    ["telefono"] = reader.IsDBNull(5) ? null : reader.GetString(5),
                    ["fecha"] = reader.IsDBNull(6) ? null : reader.GetDateTime(6).ToString("yyyy-MM-dd"),
                    ["correo"] = reader.IsDBNull(7) ? null : reader.GetString(7),
                    ["direccion"] = reader.IsDBNull(8) ? null : reader.GetString(8),
                    ["fotoRuta"] = reader.IsDBNull(9) ? null : reader.GetString(9)
                };
                return Ok(resp);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno", detalle = ex.Message });
            }
        }
    }
}
