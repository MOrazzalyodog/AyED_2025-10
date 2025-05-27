using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool continuar = true;

            Console.WriteLine("Bienvenido al programa de opciones.");

            while (continuar)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Multiplicar dos números");
                Console.WriteLine("2. Sumar dos números");
                Console.WriteLine("3. Mostrar la fecha actual");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el primer número: ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La multiplicacion  es: " + (num1 * num2));
                            break;

                        case 2:
                            Console.Write("Ingrese el primer número: ");
                            int num3 = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            int num4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La suma es: " + (num3 + num4));
                            break;

                        case 3:
                            Console.WriteLine("La fecha y hora actual es: " + DateTime.Now);
                            break;

                        case 4:
                            continuar = false;
                            Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }
        }
    }
}
