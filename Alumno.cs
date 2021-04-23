using System;

namespace Alumnos
{
    class Alumno : Persona
    {
        public int matricula;

        public Alumno(string nombre, string apellido, int matricula) : base(nombre, apellido)
     {
         if(matricula <= 0)
         {
             //Excepcion: la matricula debe ser mayor o igual a 1
             throw new ArgumentException("La matricula debe ser mayor o igual a 1");
         }
         if(nombre== "")
         {
            
             throw new ArgumentException("debe haber nombre");
         }
        if(apellido == "")
         {
             
             throw new ArgumentException("debe haber apellido");
         }
        if(nombre == null)
         {
             //Excepcion: la matricula debe ser mayor o igual a 1
             throw new ArgumentException("debe existir nombre");
         }

        if(apellido == null)
         {
             //Excepcion: la matricula debe ser mayor o igual a 1
             throw new ArgumentException("debe existir apellido");
         }

         this.matricula=matricula;
     }
        
    }


}