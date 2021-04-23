using System;
using NUnit.Framework;

namespace Alumnos
{
    [TestFixture]
    class UnitTests
    {   [Test, Description("Alumno tiene nombre, apellido y matricula")]
        public void TestAlumno()
        {
            Alumno alumno = new Alumno("Pablo", "Pabloson", 7289);

            //Materia materia = new Materia("Programacion",6);

            Assert.That(alumno.nombre, Is.EqualTo("Pablo"));
            Assert.That(alumno.matricula, Is.EqualTo(7289));
            Assert.That(alumno.apellido, Is.EqualTo("Pabloson"));

            //  Alumno alumno2 = new Alumno("Mario", "Marioson", 9090);

            // Assert.That(alumno.nombre, Is.EqualTo("Mario"));
            // Assert.That(alumno.matricula, Is.EqualTo(9090));
            // Assert.That(alumno.apellido, Is.EqualTo("Marioson"));
        }   
        [Test, Description("Alumno valida correctamente la nombre, apellido,matricula")]
        public void TestNombreApellidoMatriculaAlumno(){
            //probar lo que esta mal, debe arrojar una excepcion
            Assert.Throws<ArgumentException>(
                () => {
            Alumno pablo = new Alumno("Pablo", "Pabloson", -43);

                }
            );
            Assert.Throws<ArgumentException>(
                () => {
            Alumno mario = new Alumno("Mario", "Marioson", 0);

                }
            );

             Assert.Throws<ArgumentException>(
                () => {
            Alumno mario = new Alumno("", "Marioson", 7878);

                }
            );
            Alumno mario = new Alumno(null, "Marioson", 7878);
        }

        [Test, Description("Grupo maneja alumnos correctamente")]
        public void TestAlumnosGrupo(){
            Grupo grupoSexto = new Grupo("Sexto", 6);
            Assert.That(grupoSexto.alumnos.Count, Is.EqualTo(0));
            Alumno pablo = new Alumno("Pablo", "Pabloson", 7289);
            grupoSexto.AgregarAlumno(pablo);
             Assert.That(grupoSexto.alumnos.Count, Is.EqualTo(1));
             Assert.That(grupoSexto.alumnos[0], Is.EqualTo(pablo));

            Alumno mario = new Alumno("Mario", "Marioson", 9090);
            grupoSexto.AgregarAlumno(mario);
             Assert.That(grupoSexto.alumnos.Count, Is.EqualTo(2));
             Assert.That(grupoSexto.alumnos[1], Is.EqualTo(mario));


        }

        [Test, Description("Materia valida correctamente el nombre y semestre")]
        public void TestNombreSemestreMateria(){
            Materia matematicasI = new Materia("Matematicas I", 2);
            Assert.That(matematicasI.nombre, Is.EqualTo("Matematicas I"));
            Assert.That(matematicasI.semestre, Is.EqualTo(2));
        }
        [Test, Description("Alumno valida correctamente la materia")]
        public void TestMaterias(){
            Assert.Throws<ArgumentException>(
                () => {
            Materia materia = new Materia("",6);

                }
            );
            Assert.Throws<ArgumentException>(
                () => {
            Materia materia2 = new Materia("Programacion",-6);
                }
            );
        }

        [Test, Description("Grupo maneja materias correctamente")]
        public void TestMateriasGrupo(){
            Grupo sexto = new Grupo ("Sexto semestre", 6);
            Materia ingenieriaDeCalidad = new Materia("Ingenieria de calidad", 6);
            Materia interfaces = new Materia("Interfaces", 6);

            Assert.That(sexto.materias.Count, Is.EqualTo(0));

            sexto.AgregarMaterias(ingenieriaDeCalidad);
            Assert.That(sexto.materias.Count, Is.EqualTo(1));
            Assert.That(sexto.materias[0],Is.EqualTo(ingenieriaDeCalidad));

            sexto.AgregarMaterias(interfaces);
            Assert.That(sexto.materias.Count, Is.EqualTo(2));
            Assert.That(sexto.materias[1],Is.EqualTo(interfaces));

        }
        [Test, Description("Grupo valida el semestre de materias agregadas correctamente")]
        public void TestSemestreMateriasGrupo(){

            Grupo sexto = new Grupo("Sexto semstre", 6);
            Materia matematicasI = new Materia("Matematicas I", 2);
            Materia inteligenciaArtificial = new Materia("Inteligencia Artificial", 7);
            Materia reconocimientoDePatrones = new Materia("Reconocimiento de Patrones", 6);

            Assert.Throws<ArgumentException>(
                () => {
                    sexto.AgregarMaterias(matematicasI);
                }
            );
            Assert.That(sexto.materias.Count, Is.EqualTo(0));

            sexto.AgregarMaterias(reconocimientoDePatrones);
            Assert.That(sexto.materias.Count, Is.EqualTo(1));

        }
    }
}