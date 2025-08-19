using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_1
{
    class Program
    {
        static int Suma(int a, int b) 
        {
            return a + b; 
        }
        static void Main(string[] args)
        {
            int resultado = Suma(5, 3);
            Console.WriteLine(resultado);
            Console.ReadKey();
             
        }


    }
}
