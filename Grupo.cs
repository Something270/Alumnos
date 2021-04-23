using System;
using System.Collections.Generic; 

namespace Alumnos
{
    class Grupo
    {
        public string nombre;
        public int semestre;
        
        public List<Alumno> alumnos =new List<Alumno>();
        public List<Materia> materias = new List<Materia>();

        public Grupo(string nombre, int semestre){
            this.nombre = nombre;
            this.semestre = semestre;
        }
        

        public void AgregarAlumno(Alumno alumno){
            alumnos.Add(alumno);
        }
        public void QuitarAlumno(Alumno alumno){
            alumnos.Remove(alumno);
        }

        public void AgregarMaterias(Materia materia){
            materias.Add(materia);
        }
        public void QuitarMateria(Materia materia){
            materias.Remove(materia);
        }

        // mostrar informacion del grupo
        public void Showgrupo(string nombre, int semestre){
        this.nombre = nombre;
        this.semestre = semestre;
        Console.WriteLine(alumnos.Count);
        materias.ForEach(Console.WriteLine);
        }

    }
}