
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_2
{
    class Program
    {
        

        static void Calculadora()
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Sumar(num1, num2);
                    break;
                case 2:
                    resultado = Restar(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicar(num1, num2);
                    break;
                case 4:
                    resultado = Dividir(num1, num2);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por 0");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Calculadora();
        }
    }
}