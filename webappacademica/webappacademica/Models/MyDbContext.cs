using Microsoft.EntityFrameworkCore;

namespace webappacademica.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(a => a.idAlumno);
            modelBuilder.Entity<Materia>().HasKey(m => m.idMateria);
            modelBuilder.Entity<Docente>().HasKey(d => d.idDocente);
        }
    }
}