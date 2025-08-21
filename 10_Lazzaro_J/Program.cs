using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija la opcion:");
            string op = Console.ReadLine();
            Console.WriteLine("escriba el valor 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor 2:");
            int b = int.Parse(Console.ReadLine());

            calculadora(a, b, op);

            Console.ReadKey();
        }

        static int sumar(int a, int b)
        {
            return a + b;

        }

        static int restar(int a, int b)
        {
            return a - b;
        }

        static int multiplicar(int a, int b)
        {
            return a * b;
        }

        static int dividir(int a, int b)
        {
            return a / b;
        }

        static void calculadora(int a, int b, string op)
        {
            switch (op)
            {
                case "sumar":
                    Console.WriteLine(sumar(a, b));
                    break;
                case "restar":
                    Console.WriteLine(restar(a, b));
                    break;
                case "multiplicar":
                    Console.WriteLine(multiplicar(a, b));
                    break;
                case "dividir":
                    Console.WriteLine(dividir(a, b));
                    break;
            }
        }

    }
}