using System;
using System.Collections.Generic; 

namespace Alumnos
{
    class Grupo
    {
        string nombre;
        int semestre;
        
        List<Alumno> alumnos =new List<Alumno>();
        List<Alumno> materias = new List<Alumno>();
        

        public void AgregarAlumno(Alumno alumno){
            alumnos.Add(alumno);
        }
        public void QuitarAlumno(Alumno alumno){
            alumnos.Remove(alumno);
        }

        public void AgregarMaterias(Alumno materia){
            materias.Add(materia);
        }
        public void QuitarMateria(Alumno materia){
            materias.Remove(materia);
        }
    }
}