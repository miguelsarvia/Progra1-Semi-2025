using System.ComponentModel.DataAnnotations;


namespace proyectofinal.Models
{
    public class usuarioPaciente
    {
        [Key]
        public int idPacienteUsuario { get; set; }

        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        // Relación uno a uno con DatosPaciente
        public DatosPacientes? DatosPacientes { get; set; }

    }
}
