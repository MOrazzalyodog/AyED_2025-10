using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El número debe ser entero y positivo.");
                return;
            }

            Console.WriteLine("\nCuenta atrás:");

            for (int i = numero; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

}
