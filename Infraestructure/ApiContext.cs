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
            AlumnoConfiguration.Config(modelBuilder);
            CursoConfiguration.Config(modelBuilder);
        }

    }

}