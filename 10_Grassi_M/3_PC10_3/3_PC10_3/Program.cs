using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_3
{
    class Program
    {
        static string[,] encargos = new string[25, 5];
        static int cantidadEncargos = 0;

        public static void Main(string[] args)
        {
            bool continuar = true;
            int opcion;
           

            while (continuar)
            {
                MostrarMenuPrincipal();
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            CrearNuevoEncargo();
                            break;
                        case 2:
                            MostrarTodosLosEncargos();
                            break;
                        case 3:
                            AsignarCamionAEncargo();
                            break;
                        case 4:
                            MostrarEncargosAsignados(); 
                            break;
                        case 5:
                            CalcularPromedioGananciaPorSede(); 
                            break;
                        case 6:
                            MostrarEncargoMayorDistancia(); 
                            break;
                        case 7:
                            FiltrarEncargosPorCodigoCamion();
                            break;
                        case 8:
                            continuar = false;
                            Console.WriteLine("Cerrando programa...");
                            Console.WriteLine("Adios.");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 8.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("--- Menú Principal ---");
            Console.WriteLine("Opción 1: Crear nuevo encargo.");
            Console.WriteLine("Opción 2: Mostrar todos los encargos.");
            Console.WriteLine("Opción 3: Asignar camión a encargo.");
            Console.WriteLine("Opción 4: Mostrar todos los encargos asignados.");
            Console.WriteLine("Opción 5: Promedio de ganancia por sede.");
            Console.WriteLine("Opción 6: Mostrar el encargo con mayor distancia.");
            Console.WriteLine("Opción 7: Filtrar encargos por código de camión.");
            Console.WriteLine("Opción 8: Salir.");
            Console.WriteLine("Seleccione una opción.");
        }

        static void CrearNuevoEncargo()
        {
            Console.Clear();
            if (cantidadEncargos < 25)
            {
                Console.Write("Ingrese el código del camión: ");
                encargos[cantidadEncargos, 0] = Console.ReadLine();

                int distancia;
                do
                {
                    Console.Write("\nIngrese la distancia en KM (mayor a 0): ");
                } while (!int.TryParse(Console.ReadLine(), out distancia) || distancia <= 0);
                encargos[cantidadEncargos, 1] = distancia.ToString();

                Console.Write("\nIngrese la sede:\n1. Buenos Aires (BS.AS.).\n2. Bahía Blanca (BB). \n3. Mar del Plata (MDQ). ");
                string sedeInput = Console.ReadLine();
                encargos[cantidadEncargos, 2] = sedeInput.ToUpper();
                double ganancia;
                do
                {
                    Console.WriteLine("\nIngrese la ganancia esperada del encargo (en pesos argentinos): ");
                } while (!double.TryParse(Console.ReadLine(), out ganancia));
                encargos[cantidadEncargos, 3] = ganancia.ToString();

                encargos[cantidadEncargos, 4] = "";
                cantidadEncargos++;
                Console.WriteLine("\n¡Encargo registrado con éxito!");
            }
            else
            {
                Console.WriteLine("No hay más espacio... ¡Estamos a Full!.");
            }
        }

        static void MostrarTodosLosEncargos()
        {
            Console.Clear();
            Console.WriteLine("Encargos totales:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
            }

            if (cantidadEncargos == 0)
            {
                Console.WriteLine("No hay encargos registrados para mostrar.");
            }
        }

        static void AsignarCamionAEncargo()
        {
            Console.Clear();
            Console.WriteLine("Encargos no asignados:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            bool hayEncargosNoAsignados = false;
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (string.IsNullOrEmpty(encargos[i, 4]))
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\tNO ASIGNADO");
                    hayEncargosNoAsignados = true;
                }
            }

            if (!hayEncargosNoAsignados)
            {
                Console.WriteLine("No hay encargos sin asignar.");
                return; 
            }

            int nencargo;
            do
            {
                Console.Write("\nIngrese el N° de encargo a asignar: ");
            } while (!int.TryParse(Console.ReadLine(), out nencargo) || nencargo < 1 || nencargo > cantidadEncargos);

            nencargo--;

            if (string.IsNullOrEmpty(encargos[nencargo, 4]))
            {
                Console.Write("Ingrese el código del camión a asignar: ");
                string codcamion = Console.ReadLine();
                encargos[nencargo, 4] = codcamion;
                Console.WriteLine("Encargo asignado con éxito.");
            }
            else
            {
                Console.WriteLine("El encargo seleccionado ya tiene un camión asignado.");
            }
        }

        static void MostrarEncargosAsignados()
        {
            Console.Clear();
            Console.WriteLine("Encargos asignados:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            bool hayEncargosAsignados = false;

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (!string.IsNullOrEmpty(encargos[i, 4]))
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
                    hayEncargosAsignados = true;
                }
            }

            if (!hayEncargosAsignados)
            {
                Console.WriteLine("No hay encargos asignados para mostrar.");
            }
        }


        static void CalcularPromedioGananciaPorSede()
        {
            Console.Clear();
            Console.WriteLine("Promedio de ganancia por sede:");

            double totalGananciasBSAS = 0, totalGananciasBB = 0, totalGananciasMDQ = 0;
            int countBSAS = 0, countBB = 0, countMDQ = 0;

            for (int i = 0; i < cantidadEncargos; i++)
            {
                string sedeActual = encargos[i, 2].ToUpper().Trim();
                double ganancia;
                bool gananciaValida = double.TryParse(encargos[i, 3], out ganancia);

                if (!gananciaValida)
                {
                    continue;
                }

                switch (sedeActual)
                {
                    case "1":
                    case "BS.AS.":
                        totalGananciasBSAS += ganancia;
                        countBSAS++;
                        break;
                    case "2":
                    case "BB":
                        totalGananciasBB += ganancia;
                        countBB++;
                        break;
                    case "3":
                    case "MDQ":
                        totalGananciasMDQ += ganancia;
                        countMDQ++;
                        break;
                }
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"BS.AS.: {(countBSAS > 0 ? (totalGananciasBSAS / countBSAS).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Bahía Blanca: {(countBB > 0 ? (totalGananciasBB / countBB).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Mar del Plata: {(countMDQ > 0 ? (totalGananciasMDQ / countMDQ).ToString("0.00") : "Sin datos\n")}");
        }

        static void MostrarEncargoMayorDistancia()
        {
            Console.Clear();
            Console.WriteLine("Encargo(s) con mayor distancia:");

            if (cantidadEncargos == 0)
            {
                Console.WriteLine("No hay encargos registrados.");
                return;
            }

            int maxDistancia = 0;
            int distanciaActual;

            if (int.TryParse(encargos[0, 1], out distanciaActual))
            {
                maxDistancia = distanciaActual;
            }

            for (int i = 1; i < cantidadEncargos; i++)
            {
                if (int.TryParse(encargos[i, 1], out distanciaActual))
                {
                    if (distanciaActual > maxDistancia)
                    {
                        maxDistancia = distanciaActual;
                    }
                }
            }

            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");
            int cantidadMaximos = 0;
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (int.TryParse(encargos[i, 1], out distanciaActual) && distanciaActual == maxDistancia)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
                    cantidadMaximos++;
                }
            }

            if (cantidadMaximos > 1)
            {
                Console.WriteLine($"\nSe encontraron {cantidadMaximos} encargos con la misma distancia máxima de {maxDistancia} km.");
            }
        }

        static void FiltrarEncargosPorCodigoCamion()
        {
            Console.Clear();
            Console.Write("Ingrese el código de camión a buscar: ");
            string codigoInvestigador = Console.ReadLine();

            bool hayAsignados = false;

            Console.WriteLine($"\nEncargos asignados al camión {codigoInvestigador}:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == codigoInvestigador)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
                    hayAsignados = true;
                }
            }

            if (!hayAsignados)
            {
                Console.WriteLine("No hay encargos asignados a este camión.");
            }
        }
    }
}