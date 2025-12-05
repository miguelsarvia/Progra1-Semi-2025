using System.ComponentModel.DataAnnotations;

namespace proyectofinal.Models
{
    public class UsuarioSecretaria
    {
        [Key]
        public int idSecretaria { get; set; }

        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        // Relación uno a uno con DatosSecretaria
        public DatosSecretaria? DatosSecretaria { get; set; }

    }
}
