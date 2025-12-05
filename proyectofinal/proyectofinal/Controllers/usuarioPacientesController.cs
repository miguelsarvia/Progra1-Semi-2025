using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using proyectofinal.Models;

namespace proyectofinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioPacientesController : ControllerBase
    {
        private readonly MydbContext _context;

        public usuarioPacientesController(MydbContext context)
        {
            _context = context;
        }

        // GET: api/usuarioPacientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<usuarioPaciente>>> GetusuarioPaciente()
        {
            return await _context.usuarioPaciente.ToListAsync();
        }

        // GET: api/usuarioPacientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<usuarioPaciente>> GetusuarioPaciente(int id)
        {
            var usuarioPaciente = await _context.usuarioPaciente.FindAsync(id);

            if (usuarioPaciente == null)
            {
                return NotFound();
            }

            return usuarioPaciente;
        }

        // NUEVO: Obtener datos del paciente (DatosPacientes) por idPacienteUsuario
        [HttpGet("obtenerDatosPaciente/{idPacienteUsuario}")]
        public async Task<IActionResult> ObtenerDatosPaciente(int idPacienteUsuario)
        {
            var datos = await _context.DatosPacientes.FirstOrDefaultAsync(d => d.idPacienteUsuario == idPacienteUsuario);
            if (datos == null) return NotFound(new { mensaje = "No hay datos registrados para este paciente" });
            return Ok(new
            {
                nombre = datos.nombre,
                apellido = datos.apellido,
                dui = datos.dui,
                telefono = datos.telefono,
                fecha = datos.fecha,
                direccion = datos.direccion
            });
        }

        // PUT: api/usuarioPacientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutusuarioPaciente(int id, usuarioPaciente usuarioPaciente)
        {
            if (id != usuarioPaciente.idPacienteUsuario)
            {
                return BadRequest();
            }

            _context.Entry(usuarioPaciente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usuarioPacienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/usuarioPacientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostusuarioPaciente")]
        public async Task<IActionResult> PostusuarioPaciente([FromBody] usuarioPaciente usuarioPaciente)
        {
            // Validar si la contraseña ya está en uso
            bool passwordExiste = await _context.usuarioPaciente
                .AnyAsync(u => u.password == usuarioPaciente.password);

            if (passwordExiste)
            {
                var sugerencias = new List<string>();
                var random = new Random();

                while (sugerencias.Count < 3)
                {
                    string sugerida = $"pass{random.Next(1000, 9999)}";
                    bool yaExiste = await _context.usuarioPaciente.AnyAsync(u => u.password == sugerida);
                    if (!yaExiste)
                    {
                        sugerencias.Add(sugerida);
                    }
                }

                return Conflict(new
                {
                    mensaje = "La contraseña ya está en uso. Elige otra.",
                    sugerencias = sugerencias
                });
            }

            // Guardar el nuevo usuario
            _context.usuarioPaciente.Add(usuarioPaciente);
            await _context.SaveChangesAsync();

            // Devolver solo el ID para el frontend
            return Ok(new { idPacienteUsuario = usuarioPaciente.idPacienteUsuario });
        }

        [HttpPost("guardarDatosPaciente")]
        public async Task<IActionResult> GuardarDatosPaciente([FromBody] DatosPacientes paciente)
        {
            if (paciente == null)
                return BadRequest("Datos inválidos");

            bool existeUsuario = await _context.usuarioPaciente
                .AnyAsync(u => u.idPacienteUsuario == paciente.idPacienteUsuario);

            if (!existeUsuario)
                return BadRequest("El usuario no existe");

            bool yaTieneDatos = await _context.DatosPacientes
                .AnyAsync(d => d.idPacienteUsuario == paciente.idPacienteUsuario);

            if (yaTieneDatos)
                return Conflict("Este usuario ya tiene datos registrados");

            try
            {
                _context.DatosPacientes.Add(paciente);
                await _context.SaveChangesAsync();
                return Ok(new { mensaje = "Datos guardados" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpPost("validarCredenciales")]
        public async Task<IActionResult> ValidarCredenciales([FromBody] usuarioPaciente credenciales)
        {
            var usuario = await _context.usuarioPaciente
                .FirstOrDefaultAsync(u => u.email == credenciales.email);

            if (usuario == null)
                return Ok(new { valido = false, error = "email" });

            if (usuario.password != credenciales.password)
                return Ok(new { valido = false, error = "password" });

            return Ok(new { valido = true, idPacienteUsuario = usuario.idPacienteUsuario });
        }


        [HttpPost("agendarCita")]
        public async Task<IActionResult> AgendarCita([FromBody] agendaPaciente cita)
        {
            if (cita == null ||
                string.IsNullOrWhiteSpace(cita.nombre) ||
                string.IsNullOrWhiteSpace(cita.motivo) ||
                string.IsNullOrWhiteSpace(cita.hora) ||
                cita.fecha == default)
            {
                return BadRequest("Todos los campos son obligatorios");
            }

            // Verificar que el paciente existe
            bool existePaciente = await _context.usuarioPaciente
                .AnyAsync(p => p.idPacienteUsuario == cita.idPacienteUsuario);

            if (!existePaciente)
            {
                return BadRequest("El paciente no está registrado");
            }

            try
            {
                _context.agendarCita.Add(cita);
                await _context.SaveChangesAsync();
                return Ok(new { mensaje = "✅ Cita agendada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpGet("obtenerCitasPorPaciente/{idPacienteUsuario}")]
        public async Task<ActionResult<IEnumerable<agendaPaciente>>> ObtenerCitasPorPaciente(int idPacienteUsuario)
        {
            var citas = await _context.agendarCita
                .Where(c => c.idPacienteUsuario == idPacienteUsuario)
                .ToListAsync();

            return citas;
        }

        [HttpPut("actualizarCita/{id}")]
        public async Task<IActionResult> ActualizarCita(int id, [FromBody] agendaPaciente cita)
        {
            var citaExistente = await _context.agendarCita.FindAsync(id);
            if (citaExistente == null)
            {
                return NotFound();
            }

            citaExistente.nombre = cita.nombre;
            citaExistente.motivo = cita.motivo;
            citaExistente.fecha = cita.fecha;
            citaExistente.hora = cita.hora;

            _context.Entry(citaExistente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [HttpGet("obtenerCitasSemana")]
        public async Task<IActionResult> ObtenerCitasSemana()
        {
            // Obtén el lunes de la semana actual
            var hoy = DateTime.Today;
            var inicioSemana = hoy.AddDays(-(int)hoy.DayOfWeek + 1); // 1 = lunes

            // Obtén el sábado de la semana actual
            var finSemana = inicioSemana.AddDays(6);

            var citas = await _context.agendarCita
                .Where(c => c.fecha.Date >= inicioSemana.Date && c.fecha.Date <= finSemana.Date)
                .Select(c => new
                {
                    c.nombre,
                    c.hora,
                    // 1=Lunes, 2=Martes, ..., 6=Sábado
                    diaSemana = ((int)c.fecha.DayOfWeek == 0) ? 7 : (int)c.fecha.DayOfWeek,
                    fecha = c.fecha.ToString("yyyy-MM-dd")
                })
                .ToListAsync();

            return Ok(citas);
        }

        [HttpGet("obtenerCitasPorFecha/{fecha}")]
        public async Task<IActionResult> ObtenerCitasPorFecha(DateTime fecha)
        {
            var citas = await _context.agendarCita
                .Where(c => c.fecha.Date == fecha.Date)
                .Select(c => new { c.hora })
                .ToListAsync();

            return Ok(citas);
        }

        [HttpDelete("eliminarCita/{id}")]
        public async Task<IActionResult> EliminarCita(int id)
        {
            var cita = await _context.agendarCita.FindAsync(id);
            if (cita == null)
            {
                return NotFound();
            }

            _context.agendarCita.Remove(cita);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitaExists(int id)
        {
            return _context.agendarCita.Any(e => e.idCita == id);
        }

        private bool usuarioPacienteExists(int id)
        {
            return _context.usuarioPaciente.Any(e => e.idPacienteUsuario == id);}
    }
}