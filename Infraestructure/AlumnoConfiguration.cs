using Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Infraestructure
{
    public class AlumnoConfiguration
    {
        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder
           .Entity<Alumno>(alumno =>
           {
               alumno.HasKey(a => a.Id);

               alumno.HasOne<Curso>(a => a.Curso)
               .WithMany(c => c.Alumnos);

           });

        }

    }

}
