using Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Infraestructure
{
    public class CursoConfiguration
    {
        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder
         .Entity<Curso>(curso =>
         {
             curso.HasKey(c => c.Id);
         });
        }
    }

}