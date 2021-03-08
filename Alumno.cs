using System;

namespace Alumnos
{
    class Alumno : Persona
    {
        public int matricula;

        public Alumno(string nombre, string apellido, int matricula) : base(nombre, apellido)
     {
         this.matricula=matricula;
     }
        
    }


}