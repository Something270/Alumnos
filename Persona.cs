using System;

namespace personas
{
    class Persona
    {
        public string nombre;
         public string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void Presentarse()
        {
            //Console.WriteLine("Hola mi nombre es " + this.nombre);
            Console.WriteLine($"Hola mi nombre es {this.nombre} {this.apellido}");
        }
    }
}