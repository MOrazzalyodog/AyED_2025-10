using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochenc = 0;
            string nombre;
            string tipo;
            string nivel;
            string estado;
            string invasig;
            Random Rand = new Random();
            int sumar = random.Next(1, 4);
            bool salir = false;
            string[,] tabla = new string[75, 6];

            do
            {
                Console.Clear();
                Console.WriteLine("---- Menú principal - CIP ----");
                Console.WriteLine("Pochimones encontrados: " + pochenc + "/75");

                Console.WriteLine("1. Regristar Pochimon");
                Console.WriteLine("2. Asignar investigador a Pochimon");
                Console.WriteLine("3. Actualizar nivel del Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar informacion de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Ingrese una opción: ");
                string elec = Console.ReadLine();

                switch (elec)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Registrar Pochimon");

                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Tipo (Agua, Fuego o Planta): ");
                        tipo = Console.ReadLine();

                        Console.Write("Nivel del Pochimon: ");
                        nivel = Console.ReadLine();

                        tabla[pochenc, 0] = (pochenc + 1).ToString(); // Fila
                        tabla[pochenc, 1] = nombre;
                        tabla[pochenc, 2] = tipo;
                        tabla[pochenc, 3] = nivel;
                        tabla[pochenc, 4] = "0";
                        tabla[pochenc, 5] = "0";

                        pochenc++;

                        Console.WriteLine("Se registró el Pochimon.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Pochimons sin investigador:");
                        Console.WriteLine("Fila\tNombre\t\tTipo\tNivel");
                        Console.WriteLine("--------------------------------------------------");
                        for (int i = 0; i < pochenc; i++)
                        {
                            if (tabla[i, 4] == "0")
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}");
                                Console.WriteLine("--------------------------------------------------");
                            }
                        }
                        Console.Write("Ingrese la fila del Pochimon a asignar un investigador: ");
                        int selec = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el codigo del investigador: ");
                        invasig = Console.ReadLine();
                        tabla[selec - 1, 4] = "1";
                        tabla[selec - 1, 5] = invasig;
                        Console.WriteLine("Investigador asignado correctamente.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();

                        if (pochenc == 0)
                        {
                            Console.WriteLine("No hay Pochimons registrados.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Pochimons registrados:");
                            Console.WriteLine("Fila\tNombre\t\tTipo\tNivel");
                            Console.WriteLine("--------------------------------------------------");
                            for (int i = 0; i < pochenc; i++)
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}");
                            }
                            Console.Write("Ingrese la fila del Pochimon a actualizar nivel: ");
                            int selec2 = int.Parse(Console.ReadLine());
                            tabla[selec2 - 1, 3] = (int.Parse(tabla[selec2 - 1, 3]) + random.Next(1, 4)).ToString();

                            Console.WriteLine("Nivel actualizado correctamente.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Pochimons en investigación:");
                        Console.WriteLine("Fila\tNombre\t\tTipo\tNivel\tEstado\tInvestigador");
                        Console.WriteLine("--------------------------------------------------------");

                        for (int i = 0; i < pochenc; i++)
                        {
                            if (tabla[i, 4] == "1")
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                estado = tabla[i, 4];
                                invasig = tabla[i, 5];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}\t{estado}\t{invasig}");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese la fila del Pochimon a marcar como investigado: ");
                                int selec3 = int.Parse(Console.ReadLine());
                                tabla[selec3 - 1, 4] = "2";
                            }
                        }
                        Console.WriteLine("Actualizacion completa.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("---- Información de Pochimons ----");

                        if (pochenc == 0)
                        {
                            Console.WriteLine("No hay Pochimons registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Fila\tNombre\t\tTipo\tNivel\tEstado\tInvestigador");
                            Console.WriteLine("--------------------------------------------------------");
                            for (int i = 0; i < pochenc; i++)
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                estado = tabla[i, 4];
                                invasig = tabla[i, 5];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}\t{estado}\t{invasig}");
                            }
                        }

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Buscar Pochimons por Tipo");
                        Console.Write("Ingrese el tipo de Pochimon (Agua, Fuego o Planta): ");
                        string buscar = Console.ReadLine().ToUpper();
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Fila\tNombre\t\tTipo\tNivel\tEstado\tInvestigador");
                        Console.WriteLine("--------------------------------------------------------");
                        for (int i = 0; i < pochenc; i++)
                        {
                            if (tabla[i, 2].ToUpper() == buscar)
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                estado = tabla[i, 4];
                                invasig = tabla[i, 5];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}\t{estado}\t{invasig}");
                            }
                        }
                        Console.WriteLine("Busqueda completa.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Buscar Pochimons por investigador");
                        Console.Write("Ingrese el numero de investigador: ");
                        string buscarr = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Fila\tNombre\t\tTipo\tNivel\tEstado\tInvestigador");
                        Console.WriteLine("--------------------------------------------------------");
                        for (int i = 0; i < pochenc; i++)
                        {
                            if (tabla[i, 5] == buscarr)
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                estado = tabla[i, 4];
                                invasig = tabla[i, 5];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}\t{estado}\t{invasig}");
                            }
                        }
                        Console.WriteLine("Busqueda completa.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Buscar Pochimons picados");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Fila\tNombre\t\tTipo\tNivel");
                        Console.WriteLine("--------------------------------------------------------");
                        for (int i = 0; i < pochenc; i++)
                        {
                            if (int.Parse(tabla[i, 3]) >= 30)
                            {
                                string fila = tabla[i, 0];
                                nombre = tabla[i, 1];
                                tipo = tabla[i, 2];
                                nivel = tabla[i, 3];
                                estado = tabla[i, 4];
                                invasig = tabla[i, 5];
                                Console.WriteLine($"{fila}\t{nombre}\t\t{tipo}\t{nivel}");
                            }
                        }
                        Console.WriteLine("Busqueda completa.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "9":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                }

            } while (!salir);

        }
    }
}
