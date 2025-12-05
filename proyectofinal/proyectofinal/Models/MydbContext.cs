using Microsoft.EntityFrameworkCore;
namespace proyectofinal.Models
{
    public class MydbContext : DbContext
    {
        public MydbContext(DbContextOptions<MydbContext> options) : base(options) { }
        public DbSet<usuarioPaciente> usuarioPaciente { get; set; }
        public DbSet<DatosPacientes> DatosPacientes { get; set; }
        public DbSet<agendaPaciente> agendarCita { get; set; }



        //Conexion a la base de datos; a la tabla usuarioPaciente.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación uno a uno entre usuarioPaciente y DatosPacientes
            modelBuilder.Entity<usuarioPaciente>()
                .HasOne(u => u.DatosPacientes)
                .WithOne(d => d.usuarioPaciente)
                .HasForeignKey<DatosPacientes>(d => d.idPacienteUsuario);

            // Relación uno a muchos entre usuarioPaciente y agendaPaciente
            modelBuilder.Entity<agendaPaciente>()
          .HasOne(a => a.DatosPacientes)
          .WithMany(d => d.Citas)
          .HasForeignKey(a => a.idPacienteUsuario)
          .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

        }
    }
}
