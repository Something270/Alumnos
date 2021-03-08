using System;

namespace Alumnos
{
    class Alumno : Persona
    {
        public int matricula
    }

     public Alumno(string nombre, string apellido, int matricula)
     {
         this.nombre= nombre;
         this.apellido=apellido;
         this.matricula=matricula;
     }
}