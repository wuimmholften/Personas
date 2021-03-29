using System;
using NUnit.Framework;

namespace Alumnos
{
    [TestFixture]
    class UnitTests
    {
        [Test, Description("Alumno tiene nombre, apellildo y matrícula")]
        public void TestAlumno()
        {
            Alumno alumno = new Alumno("Pablo", "Pabloson", 7289);

            // Revisar que alumno.nombre es igual a Pablo
            // Assert that alumno.nombre is equal to Pablo
            Assert.That(alumno.nombre, Is.EqualTo("Pablo"));
            Assert.That(alumno.apellido, Is.EqualTo("Pabloson"));
            // Assert.That(alumno.apellido, Is.EqualTo("Picapiedra"));
            Assert.That(alumno.matricula, Is.EqualTo(7289));
        }

        [Test, Description("Alumno valida correctamente nombre, apellido y matrícula")]
        public void TestNombreApellidoMatriculaAlumno()
        {
            // Probar que lo que está mal, debe arrojar una Excepción

            // Alumno pablo = new Alumno("Pablo", "Pabloson", -43);
            // Alumno julio = new Alumno("Julio", "Julioson", 0);
            

            Assert.Throws<ArgumentException>(
                () => {
                    Alumno pablo = new Alumno("Pablo", "Pabloson", -43);
                }
            );
            Assert.Throws<ArgumentException>(
                () => {
                    Alumno julio = new Alumno("Julio", "Julioson", 0);
                }
            );

            Assert.Throws<ArgumentException>(
                () => {
                    Alumno pablo = new Alumno("", "Pabloson", 123);
                }
            );

            // TODO: Validar nombre y apellido
            // - nombre vacío ("")
            // - apellido vacío ("")
            // - sin nombre (null)
            // - sin apellido (null)

            // try-catch es para código funcional
            // try
            // {
                
            // }
            // catch (System.Exception)
            // {
                
            // }
        }

        [Test, Description("Grupo maneja alumnos correctamente")]
        public void TestAlumnosGrupo()
        {
            Grupo grupoSexto = new Grupo("Sexto", 6);

            Assert.That(grupoSexto.alumnos.Count, Is.EqualTo(0));

            Alumno pablo = new Alumno("Pablo", "Pabloson", 7289);
            grupoSexto.AgregarAlumno(pablo);

            Assert.That(grupoSexto.alumnos.Count, Is.EqualTo(1));
            Assert.That(grupoSexto.alumnos[0], Is.EqualTo(pablo));

            Alumno julio = new Alumno("Julio", "Julioson", 7290);
            grupoSexto.AgregarAlumno(julio);

            Assert.That(grupoSexto.alumnos.Count, Is.EqualTo(2));
            Assert.That(grupoSexto.alumnos[1], Is.EqualTo(julio));
            
        }

        // Validar que el semestre es válido (similar a la matrícula)
        // (Aplica para Materia y para Grupo)
        // (También se puede validar el nombre)
        [Test, Description("Materia valida correctamente el nombre y semestre")]
        public void TestNombreSemestreMateria()
        {
            // Caso de éxito - Assert.That
            // - Materia válida
            Materia matematicasI = new Materia("Matemáticas I", 2);

            Assert.That(matematicasI.nombre, Is.EqualTo("Matemáticas I"));
            Assert.That(matematicasI.semestre, Is.EqualTo(2));

            // Casos de error - Assert.Throws
            // - Materia sin nombre
            Assert.Throws<ArgumentException>(
                () => {
                    Materia matematicasII = new Materia("", 3);
                }
            );
            Assert.Throws<ArgumentException>(
                () => {
                    Materia matematicasII = new Materia(null, 3);
                }
            );
            // - Materia con semestre negativo
            Assert.Throws<ArgumentException>(
                () => {
                    Materia matematicasII = new Materia("Matemáticas II", -1);
                }
            );
            // - Materia con semestre 0
            Assert.Throws<ArgumentException>(
                () => {
                    Materia matematicasII = new Materia("Matemáticas II", 0);
                }
            );
            // - Materia con semestre mayor al permitido
            Assert.Throws<ArgumentException>(
                () => {
                    Materia matematicasIX = new Materia("Matemáticas IX", 9);
                    Materia matematicasX = new Materia("Matemáticas X", 10);
                    Materia matematicasL = new Materia("Matemáticas L", 50);
                }
            );
        }

        // Validar que las materias se agregan correctamente a un Grupo (similar a alumnos)
        [Test, Description("Grupo maneja materias correctamente")]
        public void TestMateriasGrupo()
        {
            Grupo sexto = new Grupo("Sexto semestre", 6);

            Materia ingenieriaDeCalidad = new Materia("Ingeniería de Calidad", 6);
            Materia interfaces = new Materia("Interfaces", 6);

            // - Materias comienzan vacías
            Assert.That(sexto.materias.Count, Is.EqualTo(0));

            // - Después de agregar una materia, debería de haber una materia (la agregada)
            sexto.AgregarMateria(ingenieriaDeCalidad);
            Assert.That(sexto.materias.Count, Is.EqualTo(1));
            Assert.That(sexto.materias[0], Is.EqualTo(ingenieriaDeCalidad));

            // - Después de agregar otra materia, debería de haber 2 materias (la segunda es la agregada)
            sexto.AgregarMateria(interfaces);
            Assert.That(sexto.materias.Count, Is.EqualTo(2));
            Assert.That(sexto.materias[1], Is.EqualTo(interfaces));

            // - Si quitamos la primer materia, solamente queda la segunda materia
            sexto.QuitarMateria(ingenieriaDeCalidad);
            Assert.That(sexto.materias.Count, Is.EqualTo(1));
            Assert.That(sexto.materias[0], Is.EqualTo(interfaces));

            // - Si quitamos otra materia, ya no hay materias disponibles
            sexto.QuitarMateria(interfaces);
            Assert.That(sexto.materias.Count, Is.EqualTo(0));
        }

        // TODO: Agregar prueba de validar semestre de materias agregadas a un grupo
        [Test, Description("Grupo valida el semestre de materias agregadas correctamente")]
        public void TestSemestreMateriasGrupo()
        {
            Grupo sexto = new Grupo("Sexto semestre", 6);
            Materia matematicasI = new Materia("Matemáticas I", 2);
            Materia inteligenciaArtificial = new Materia("Inteligencia Artificial", 7);
            Materia reconocimientoDePatrones = new Materia("Reconocimiento de Patrones", 6);

            Assert.Throws<ArgumentException>(
                () => {
                    sexto.AgregarMateria(matematicasI);
                }
            );
            Assert.That(sexto.materias.Count, Is.EqualTo(0));


            Assert.Throws<ArgumentException>(
                () => {
                    sexto.AgregarMateria(inteligenciaArtificial);
                }
            );
            Assert.That(sexto.materias.Count, Is.EqualTo(0));

            sexto.AgregarMateria(reconocimientoDePatrones);
            Assert.That(sexto.materias.Count, Is.EqualTo(1));
        }
    }
}