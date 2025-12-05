using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectofinal.Models
{
    public class agendaPaciente
    {
        [Key]
        public int idCita { get; set; }

        public int idPacienteUsuario { get; set; }

        public string nombre { get; set; } = string.Empty;

        public string motivo { get; set; } = string.Empty;

        public DateTime fecha { get; set; }

        public string hora { get; set; } = string.Empty;


        // 🔗 Relación con DatosPacientes
        public DatosPacientes? DatosPacientes{ get; set; }

    }
}
