using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectofinal.Models
{
    public class DatosPacientes
    {
        [Key]
        [ForeignKey("usuarioPaciente")]
        public int idPacienteUsuario { get; set; }


        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public string dui { get; set; } = string.Empty;
        public DateTime fecha { get; set; }
        public string telefono { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;

        // Relación inversa

            public usuarioPaciente? usuarioPaciente { get; set; }
            public ICollection<agendaPaciente>? Citas { get; set; }

    }
}

