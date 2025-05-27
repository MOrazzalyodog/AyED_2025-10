using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_0
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;
            int ingresos;
            Console.WriteLine("decime tu edad ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("decime tus ingresos mensuales ");
            ingresos = int.Parse(Console.ReadLine());

            if(edad >= 19 && ingresos <= 100000)
            {  
                Console.WriteLine("podes cobrar la beca!");
             }
            else if(edad < 19 && ingresos == 0  )
            {
                Console.WriteLine("podes cobrar la beca");
            }
            else if(edad == 19 && ingresos == 50000)
            {
                Console.WriteLine("podes cobrar la beca");
            }
            else
            {
                Console.WriteLine(" NO podes cobrar la beca");
            }

            Console.ReadKey();



        }
    }
}
