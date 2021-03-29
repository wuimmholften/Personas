using System;
using System.Collections.Generic;


namespace Alumnos
{
    class Grupo
    {

        public string nombre;
        public int semestre;

        public List<Alumno> alumnos = new List<Alumno>();
        public List<Materia> materias = new List<Materia>();

        public Grupo(string nombre, int semestre)
        {
            this.nombre = nombre;
            this.semestre = semestre;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void QuitarAlumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }

        public void AgregarMateria(Materia materia)
        {
            materias.Add(materia);
        }

        public void QuitarMateria(Materia materia)
        {
            materias.Remove(materia);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Grupo");
            Console.WriteLine("----------------");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Semestre: " + this.semestre);
            Console.WriteLine("Alumnos: " + this.alumnos.Count);
            Console.WriteLine("Materia: ");

            foreach(var materia in materias)
            {
                Console.WriteLine(materia.nombre);
            }
            Console.WriteLine("");
            Console.WriteLine("----------------");
            

        }
            
        
    }
}