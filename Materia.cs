using System;

namespace Alumnos
{
    public class Materia
    {
        public string nombre;
        public int semestre;

        public static readonly int CANTIDAD_SEMESTRES = 8;

        public Materia(string nombre, int semestre)
        {
            if (nombre == "" || nombre == null)
            {
                throw new ArgumentException("El nombre de una Materia es obligatorio");
            }
            if (semestre <= 0)
            {
                throw new ArgumentException("Se debe indicar un semestre mayor que 0");
            }
            if (semestre > CANTIDAD_SEMESTRES)
            {
                throw new ArgumentException("El número máximo de semestre permitido es " + CANTIDAD_SEMESTRES);
            }
            this.nombre = nombre;
            this.semestre = semestre;
        }
    }
}