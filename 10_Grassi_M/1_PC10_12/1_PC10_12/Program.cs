using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string SIONO = ""; 

            while (SIONO != "SI")
            {
                Console.WriteLine("¿Desea terminar el programa? (Responda SI para terminar)");
                SIONO = Console.ReadLine();
            }

            Console.WriteLine("Programa terminado.");
        }
    }
}
