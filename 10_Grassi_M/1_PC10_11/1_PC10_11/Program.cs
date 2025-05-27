    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Números pares del 1 al " + N + ":");
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
