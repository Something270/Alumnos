using System;

namespace Alumnos
{
    class Materia
    {
        public string nombre;
        public int semestre;

        public static readonly int CANTIDAD_SEMESTRES = 8;


        public Materia(string nombre, int semestre){

            if(nombre =="" || nombre==null)
         {
            
             throw new ArgumentException("Debe haber nombre");
         }

            if(semestre <=0)
         {
             
             throw new ArgumentException("Debe haber semestre");
         }
         if(semestre > CANTIDAD_SEMESTRES)
         {
             throw new ArgumentException("El numero maximo de semestres es " + CANTIDAD_SEMESTRES);
         }


            this.nombre = nombre;
            this.semestre = semestre;
        }
    }
}