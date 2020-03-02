using System;
using System.Collections.Generic;

namespace Api.Domain
{
    public class Curso
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Alumno> Alumnos { get; set; }
        public Curso(string nombre)
        {
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
        }
        public void AddAlumno(Alumno alumno)
        {
            this.Alumnos.Add(alumno);

        }
    }
}