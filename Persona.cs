using System;

namespace Alumnos
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        // Método sin void/string/int/etc.
        // Se llama igual que la clase
        // Método constructor
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void Presentarse()
        {
            // Console.WriteLine("Hola, mi nombre es " + this.nombre + " " + this.apellido);
            Console.WriteLine($"Hola mi nombre es {this.nombre} {this.apellido}");
        }
    }
}