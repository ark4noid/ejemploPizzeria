using System;

namespace Api.Domain
{
    public class Alumno
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public Curso Curso { get; set; }

        public Alumno(string nombre, Curso curso)
        {
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.Curso = curso;
        }
    }
}