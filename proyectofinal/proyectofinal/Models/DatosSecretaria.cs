using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectofinal.Models
{
    public class DatosSecretaria
    {
        [Key]
        [ForeignKey("UsuarioSecretaria")]
        public int idSecretaria { get; set; }


        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public string dui { get; set; } = string.Empty;
        public string especialidad { get; set; } = string.Empty;
        public string telefono { get; set; } = string.Empty;
        public DateTime fecha { get; set; }
        public string correo { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;

        // Relación inversa

        public UsuarioSecretaria?UsuarioSecretaria { get; set; }
    }
}
