using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadAlumnosMaterias
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Materias> materias = new List<Materias>();
            List<Alumnos> alumnos = new List<Alumnos>();
            List<Inscripciones> inscripciones= new List<Inscripciones>();

            int opcion; //acá vamos a guardar la opción elegida
            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        CargarMaterias(materias);
                        break;
                    case 2:
                        CargarAlumno(alumnos);
                        break;
                    case 3:
                        CargarInscripcion(inscripciones);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la materia a buscar:");
                        string buscado = Console.ReadLine();
                        List<Materias> materiasEncontrados = BuscarMaterias(materias, buscado);
                        MostrarMaterias(materiasEncontrados);
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
        private static void CargarMaterias(List<Materias> materias)
        {
            Materias m = new Materias();
            Console.WriteLine("Cargar materias");

            Console.WriteLine("Ingrese el nombre de la materia: ");
            m.NombreMateria = Console.ReadLine();
            materias.Add(m);

            Console.WriteLine("La materia se agrego exitosamente!.");

        }
        private static void CargarAlumno(List<Alumnos> alumnos)
        {
            Alumnos a = new Alumnos();
            Console.WriteLine("ingresar nombre: ");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("ingresar el apellido: ");
            a.Apellido = Console.ReadLine();
            Console.WriteLine("ingresar fecha de nacimiento: ");
            a.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ingresar documento:");
            a.Documento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de legajo: ");
            a.Legajo=int.Parse(Console.ReadLine());
            alumnos.Add(a);
            Console.WriteLine("El alumno se agrego exitosamente!.");
        }
        private static void CargarInscripcion(List<Inscripciones> inscripciones)
        {
            Inscripciones i = new Inscripciones();
            Console.WriteLine("Ingrese los datos para cargar la inscripción");
            Console.WriteLine("Año lectivo: ");
            i.AñoLectivo = int.Parse(Console.ReadLine());
            Console.WriteLine("Materia: ");
            i.Materias = Console.ReadLine();
            Console.WriteLine("Nombre y apellido del alumno: ");
            i.Alumnos=Console.ReadLine();
            if (Alumnos == Alumnos)
            {
                do
                {
                    Console.WriteLine("Error. Alumno cargado anteriormente.");
                    Console.WriteLine("Cargue el nombre y apellido de un alumno nuevo: ");
                    i.Alumnos = Console.ReadLine();
                } while (Alumnos != Alumnos);
            }
            do
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

            Console.WriteLine("Estado: " + (aprobado ? "Aprobado" : "Desaprobado"));
            inscripciones.Add(i);
            Console.WriteLine("La inscripción se cargo exitosamente!.");
        }
        private static void MostrarMaterias(List<Materias> nombreMaterias)
        {
            foreach (Materias m in nombreMaterias)
            {
                Console.WriteLine(m);
            }
        }
        private static List<Materias> BuscarMaterias(List<Materias> nombreMaterias, string buscado)
        {
            List<Materias> encontrados = new List<Materias>();
            buscado = buscado.ToLower().Trim();
            foreach (Materias m in nombreMaterias)
            {
                if (m.NombreMateria.ToLower().Contains(buscado))
                {
                    encontrados.Add(m);
                }
            }
            return encontrados;
        }
        private static List<Alumno> BuscarAlumno(List<Alumno> nombre, List<Alumno> apellido, List<Alumno> documento, List<Alumno> legajo, string buscado)
        {
            List<Alumno> encontrados = new List<Alumno>();
            buscado = buscado.ToLower().Trim();
            foreach (Materia a in nombre)
            {
                if (a.Nombre.ToLower().Contains(buscado))
                {
                    encontrados.Add(a);
                }
            }
            return encontrados;
        }

        private static void MostrarInscriptos(List<Alumno> nombre, List<Alumno> apellido, List<Alumno> legajo, List<Materia> materia)
        {
            List<Alumno> inscriptos = inscriptos(materia, año);

            if (alumnosInscriptos.Count == 0)
            {
                Console.WriteLine("No hay alumnos inscriptos en esta materia y año lectivo.");
                return;
            }

            Console.WriteLine($"Alumnos inscriptos en {materia} ({anioLectivo}):");
            foreach (var alumno in alumnosInscriptos)
            {
                string estado = alumno.Aprobado ? "Aprobado" : "No Aprobado";
                Console.WriteLine($"- {alumno.Nombre} {alumno.Apellido}: {estado}");
            }

        }
    }
}
