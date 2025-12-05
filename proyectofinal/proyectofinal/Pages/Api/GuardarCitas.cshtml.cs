using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyectofinal.Pages.Api
{
    [IgnoreAntiforgeryToken]
    public class GuardarCitasModel : PageModel
    {
        public class Cita
        {
            [Key]
            public int idCita { get; set; }
            public int? idPacienteUsuario { get; set; }
            public string nombre { get; set; }
            public string motivo { get; set; }
            public string fecha { get; set; }
            public string hora { get; set; }
        }

        [BindProperty]
        public List<Cita> Citas { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=db_proyectofinal;Trusted_Connection=True;";
            int count = 0;

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    foreach (var cita in Citas)
                    {
                        using (var cmd = new SqlCommand(
                            "INSERT INTO dbo.agendarCita (idPacienteUsuario, nombre, motivo, fecha, hora) VALUES (@idPacienteUsuario, @nombre, @motivo, @fecha, @hora)", connection))
                        {
                            cmd.Parameters.AddWithValue("@idPacienteUsuario", (object?)cita.idPacienteUsuario ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@nombre", cita.nombre);
                            cmd.Parameters.AddWithValue("@motivo", cita.motivo);
                            cmd.Parameters.AddWithValue("@fecha", cita.fecha);
                            cmd.Parameters.AddWithValue("@hora", cita.hora);

                            count += await cmd.ExecuteNonQueryAsync();
                        }
                    }
                }

                // ✅ Retorno con campo 'cantidad' para el frontend
                return new JsonResult(new { success = true, cantidad = count });
            }
            catch (Exception ex)
            {
                // ❌ Manejo de error para evitar respuestas vacías
                return BadRequest(new { success = false, error = ex.Message });
            }
        }
    }
}
