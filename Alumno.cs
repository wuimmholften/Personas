using System;

namespace Alumnos
{
    public class Alumno : Persona
    {
        public int matricula;

        public Alumno(string nombre, string apellido, int matricula) : base(nombre, apellido)
        {
            if (matricula <= 0)
            {
                // Arrojar Excepción: la matrícula debe ser mayor o igual a 1
                throw new ArgumentException("La matrícula debe ser mayor o igual a 1");
            }
            if (nombre == "")
            {
                throw new ArgumentException("La nombre es obligatorio");
            }
            this.matricula = matricula;
        }
    }
}