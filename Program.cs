using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preoblem05_Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Buscar a personas por edad");
            Console.WriteLine("================================");

            Console.Write("¿Qué edad quieres buscar?: ");
            if (int.TryParse(Console.ReadLine(), out int edadBuscada))
            {
                int vacunados = 0;
                int noVacunados = 0;

                for (int i = 0; i < totalEncuestados; i++)
                {
                    if (edades[i] == edadBuscada)
                    {
                        if (seHaVacunado[i])
                        {
                            vacunados++;
                        }
                        else
                        {
                            noVacunados++;
                        }
                    }
                }

                Console.WriteLine($"{vacunados:D2} se vacunaron");
                Console.WriteLine($"{noVacunados:D2} no se vacunaron");
            }
            else
            {
                Console.WriteLine("Ingrese una edad válida.");
            }

            Console.WriteLine("================================");
            Console.WriteLine("Presione una tecla para regresar ...");
            Console.ReadKey();
        }
        static int[] edades = new int[1000];
        static bool[] seHaVacunado = new bool[1000];
        static int totalEncuestados = 0;

        static void Main()
        {
            int opcion;

            do
            {
                MostrarMenu();
                Console.Write("Ingrese una opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Ingrese una opción válida.");
                }

            } while (opcion != 5);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Encuesta de vacunación");
            Console.WriteLine("================================");
            Console.WriteLine("1: Realizar Encuesta");
            Console.WriteLine("2: Mostrar Datos de la encuesta");
            Console.WriteLine("3: Mostrar Resultados");
            Console.WriteLine("4: Buscar Personas por edad");
            Console.WriteLine("5: Salir");
            Console.WriteLine("================================");
        }

        static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    RealizarEncuesta();
                    break;
                case 2:
                    MostrarDatosEncuesta();
                    break;
                case 3:
                    MostrarResultados();
                    break;
                case 4:
                    BuscarPorEdad();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }

        static void RealizarEncuesta()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Encuesta de vacunación");
            Console.WriteLine("===================================");

            Console.Write("¿Qué edad tienes?: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Console.WriteLine("Te has vacunado");
                Console.WriteLine("1: Sí");
                Console.WriteLine("2: No");

                Console.Write("Ingrese una opción: ");
                if (int.TryParse(Console.ReadLine(), out int opcionVacuna) && (opcionVacuna == 1 || opcionVacuna == 2))
                {
                    edades[totalEncuestados] = edad;
                    seHaVacunado[totalEncuestados] = opcionVacuna == 1;

                    totalEncuestados++;

                    Console.WriteLine("¡Gracias por participar!");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese una edad válida.");
            }

            Console.WriteLine("===================================");
            Console.WriteLine("Presione una tecla ...");
            Console.ReadKey();
        }

        static void MostrarDatosEncuesta()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Datos de la encuesta");
            Console.WriteLine("===================================");
            Console.WriteLine("ID    | Edad | Vacunado");
            Console.WriteLine("=======================");

            for (int i = 0; i < totalEncuestados; i++)
            {
                Console.WriteLine($"{i:D4}  |  {edades[i],-3}  |   {(seHaVacunado[i] ? "Si" : "No")}");
            }

            Console.WriteLine("===================================");
            Console.WriteLine("Presione una tecla para regresar ...");
            Console.ReadKey();
        }

        static void MostrarResultados()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Resultados de la encuesta");
            Console.WriteLine("===================================");

            int totalVacunados = seHaVacunado.Count(v => v);
            int totalNoVacunados = totalEncuestados - totalVacunados;

            Console.WriteLine($"{totalVacunados:D2} personas se han vacunado");
            Console.WriteLine($"{totalNoVacunados:D2} personas no se han vacunado");

            Console.WriteLine();
            Console.WriteLine($"Existen:");
            Console.WriteLine($"{ContarPersonasEnRango(1, 20):D2} personas entre 01 y 20 años");
            Console.WriteLine($"{ContarPersonasEnRango(21, 30):D2} personas entre 21 y 30 años");
            Console.WriteLine($"{ContarPersonasEnRango(31, 40):D2} personas entre 31 y 40 años");
            Console.WriteLine($"{ContarPersonasEnRango(41, 50):D2} personas entre 41 y 50 años");
            Console.WriteLine($"{ContarPersonasEnRango(51, 60):D2} personas entre 51 y 60 años");
            Console.WriteLine($"{ContarPersonasEnRango(61, int.MaxValue):D2} personas de más de 61 años");

            Console.WriteLine("===================================");
            Console.WriteLine("Presione una tecla para regresar ...");
            Console.ReadKey();
        }

        static void BuscarPorEdad()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Buscar a personas por edad");
            Console.WriteLine("================================");

            Console.Write("¿Qué edad quieres buscar?: ");
            if (int.TryParse(Console.ReadLine(), out int edadBuscada))
            {
                int vacunados = 0;
                int noVacunados = 0;

                for (int i = 0; i < totalEncuestados; i++)
                {
                    if (edades[i] == edadBuscada)
                    {
                        if (seHaVacunado[i])
                        {
                            vacunados++;
                        }
                        else
                        {
                            noVacunados++;
                        }
                    }
                }

                Console.WriteLine($"{vacunados:D2} se vacunaron");
                Console.WriteLine($"{noVacunados:D2} no se vacunaron");
            }
            else
            {
                Console.WriteLine("Ingrese una edad válida.");
            }

            Console.WriteLine("================================");
            Console.WriteLine("Presione una tecla para regresar ...");
            Console.ReadKey();
        }

        static int ContarPersonasEnRango(int edadMin, int edadMax)
        {
            return edades.Count(e => e >= edadMin && e <= edadMax);
        }
    }


}
    

