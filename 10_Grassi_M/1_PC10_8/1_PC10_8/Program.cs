using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad <= 0)
            {
                Console.WriteLine("La edad debe ser un número positivo mayor que cero.");
                return;
            }

           

            for (int i = 1; i <= edad; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadKey();
        }
    }
}
