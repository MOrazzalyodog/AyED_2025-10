using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Ingrese el tamaño del vector: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = rnd.Next(1, 101);
            }

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Imprimir todos los elementos");
                Console.WriteLine("2. Buscar un número en el vector");
                Console.WriteLine("3. Ordenar el vector");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elementos del vector:");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(vector[i] + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Ingrese el número a buscar: ");
                        int numBuscado = int.Parse(Console.ReadLine());

                        int posicion = -1;
                        for (int i = 0; i < n; i++)
                        {
                            if (vector[i] == numBuscado)
                            {
                                posicion = i;
                                break;
                            }
                        }

                        if (posicion != -1)
                        {
                            Console.WriteLine("Número encontrado en la posición {0}.", posicion);
                        }
                        else
                        {
                            Console.WriteLine("Número no encontrado en el vector.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Como quiere ordenar el vector?");
                        Console.WriteLine("1. Ascendente");
                        Console.WriteLine("2. Descendente");
                        Console.Write("Elija una opción: ");
                        int orden = int.Parse(Console.ReadLine());

                        if (orden == 1)
                        {
                            int temp;
                            for (int i = 0; i < vector.Length - 1; i++)
                            {
                                for (int j = 0; j < vector.Length - i - 1; j++)
                                {
                                    if (vector[j] > vector[j + 1])
                                    {
                                        temp = vector[j];
                                        vector[j] = vector[j + 1];
                                        vector[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Vector ordenado ascendentemente.");
                        }
                        else if (orden == 2)
                        {
                            int temp;
                            for (int i = 0; i < vector.Length - 1; i++)
                            {
                                for (int j = 0; j < vector.Length - i - 1; j++)
                                {
                                    if (vector[j] < vector[j + 1])
                                    {
                                        temp = vector[j];
                                        vector[j] = vector[j + 1];
                                        vector[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Vector ordenado descendentemente.");
                        }
                        else
                        {
                            Console.WriteLine("Opción de orden inválida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
