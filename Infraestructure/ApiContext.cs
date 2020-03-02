using Microsoft.EntityFrameworkCore;
using Api.Domain;

namespace Api.Infraestructure
{
    public class ApiContext : DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Alumno>(alumno =>
            {
                alumno.HasKey(a => a.Id);

                alumno.HasOne<Curso>(a => a.Curso)
                .WithMany(c => c.Alumnos);

            });

            modelBuilder
            .Entity<Curso>(curso =>
            {
                curso.HasKey(c => c.Id);
            });
        }

    }

}