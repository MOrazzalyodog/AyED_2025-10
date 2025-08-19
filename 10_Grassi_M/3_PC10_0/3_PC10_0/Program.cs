using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string helou = saludo("kevin!");
            Console.WriteLine(helou);

            Console.ReadKey();
        }
        static string saludo(string nombre)
        {
            return ("hola " + nombre);

        }
    }
}