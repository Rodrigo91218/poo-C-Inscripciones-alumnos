using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Materia> materia = new List<Materia>();
            List<Alumno> alumno = new List<Alumno>();
            List<Inscripcion> inscripcion = new List<Inscripcion>();

            int opcion; //acá vamos a guardar la opción elegida
            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        CargarMateria(materia);
                        break;
                    case 2:
                        CargarAlumno(alumno);
                        break;
                    case 3:
                        CargarInscripcion(inscripcion);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la materia a buscar:");
                        string buscado = Console.ReadLine();
                        List<Materia> materiasEncontrados = BuscarMateria(materia, buscado);
                        MostrarMateria(materiaEncontrada);
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                }

            } while (opcion != 0);


            Console.ReadKey();

        }

        private static int Menu()
        {
            int opcion;

            Console.WriteLine("Ingrese el número de la opción y luego enter:\n");
            Console.WriteLine("1 - Cargar materia");
            Console.WriteLine("2 - Cargar alumno");
            Console.WriteLine("3 - Cargar inscripciones");
            Console.WriteLine("4 - Buscar materia");
            Console.WriteLine("5 - Buscar alumno");
            Console.WriteLine("6 - Ver inscripciones");
            Console.WriteLine("7 - Aprobar alumnos");
            Console.WriteLine("8 - Ver materias aprobadas");

            Console.WriteLine("0 - Salir\n");

            opcion = Validacion.LeerInt(0, 8);
            return opcion;
        }
        private static void CargarMateria(List<Materia> materias)
        {
            Materia m = new Materia();
            Console.WriteLine("Cargar materia");
            Console.WriteLine("Ingrese el nombre de la materia: ");
            m.Nombre = Console.ReadLine();
            materias.Add(m);
            Console.WriteLine("La materia se agrego exitosamente!.");
        }
        private static void CargarAlumno(List<Alumno> alumno)
        {
            Alumno a = new Alumno();
            Console.WriteLine("ingresar nombre: ");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("ingresar el apellido: ");
            a.Apellido = Console.ReadLine();
            Console.WriteLine("ingresar fecha de nacimiento: ");
            a.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ingresar documento:");
            a.Documento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de legajo: ");
            a.Legajo = int.Parse(Console.ReadLine());
            alumno.Add(a);
            Console.WriteLine("El alumno se agrego exitosamente!.");
        }
        private static void CargarInscripcion(List<Inscripcion> inscripcion, List<Materia> materia, List<Alumno> alumno)
        {
            Inscripcion i = new Inscripcion();
            Console.WriteLine("Ingrese los datos para cargar la inscripción");
            Console.WriteLine("Año lectivo: ");
            i.AñoLectivo = int.Parse(Console.ReadLine());
            Console.WriteLine("Materia: ");
            i.Materia = SeleccionarMateria(Materia);
            Console.WriteLine("Ingrese algun dato del alumno: ");
            i.Alumno = SeleccionarAlumno();
            if (Alumno == Alumno)
            {
                do
                {
                    Console.WriteLine("Error. Alumno cargado anteriormente.");
                    Console.WriteLine("Cargue el nombre y apellido de un alumno nuevo: ");
                    i.Alumno = BuscarAlumno();
                } while (Alumno != Alumno);
            }
            /*do
            {
                Console.WriteLine("Ingrese 'a' para Aprobado o 'd' para Desaprobado:");
                i.Aprobado = Console.ReadLine();

                if (Aprobado == "a")
                {
                    aprobado = true;
                }
                else if (Aprobado == "d")
                {
                    aprobado = false;
                }
                else
                {
                    Console.WriteLine("Error. Por favor ingrese 'a' o 'd'.");
                }

            } while (Aprobado != "a" && Aprobado != "d");

            Console.WriteLine("Estado: " + (aprobado ? "Aprobado" : "Desaprobado"));*/
            inscripcion.Add(i);
            Console.WriteLine("La inscripción se cargo exitosamente!.");
        }

        private static Alumno SeleccionarAlumno(List<Alumno> alumno)
        {
            Console.WriteLine("Alumnos activos: ");
            int i = 1;
            foreach (Alumno a in alumno)
            {
                Console.WriteLine(i + " - " + a.ToString());
                i++;
            }
            Console.WriteLine("Ingrese el número del alumno a seleccionar: ");
            int seleccionado = Validacion.LeerInt(1, alumno.Count());

            return alumno[seleccionado - 1];

        }







        private static List<Alumno> BuscarAlumno(List<Alumno> nombre, List<Alumno> apellido, List<Alumno> documento, List<Alumno> legajo, string buscado)
        {
            List<Alumno> encontrado = new List<Alumno>();
            buscado = buscado.ToLower().Trim();
            foreach (Alumno a in nombre)
            {
                if (a.Nombre.ToLower().Contains(buscado) || a.Apellido.ToLower().Contains(buscado) || a.Documento.ToString().Contains(buscado) || a.Legajo.ToString().Contains(buscado) || string.Concat(a.Apellido, " ", a.Nombre).ToLower().Contains(buscado))
                {
                    encontrado.Add(a);
                }
            }
            return encontrado;
        }















        private static void MostrarMaterias(List<Materia> nombre)
        {
            foreach (Materia m in nombre)
            {
                Console.WriteLine(m);
            }
        }
        private static List<Materia> BuscarMateria(List<Materia> nombre, string buscado)
        {
            List<Materia> encontrar = new List<Materia>();
            buscado = buscado.ToLower().Trim();
            foreach (Materia m in nombre)
            {
                if (m.Nombre.ToLower().Contains(buscado))
                {
                    encontrar.Add(m);
                }
            }
            return encontrar;
        }
       

        private static void MostrarInscriptos(List<Alumno> nombre, List<Alumno> apellido, List<Alumno> legajo, List<Materia> materia)
        {
            List<Alumno> inscripto = inscripto(materia, año);

            if (alumnoInscripto.Count == 0)
            {
                Console.WriteLine("No hay alumnos inscriptos en esta materia y año lectivo.");
                return;
            }

            Console.WriteLine($"Alumnos inscriptos en {materia} ({añoLectivo}):");
            foreach (var alumno in alumnoInscripto)
            {
                string estado = alumno.Aprobado ? "Aprobado" : "No Aprobado";
                Console.WriteLine($"- {alumno.Nombre} {alumno.Apellido}: {estado}");
            }
        }
    }
}
