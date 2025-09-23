using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC10_11
{
    class Program
    {
        static void Main()
        {

            Console.Write("ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.Write("altura del rectángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * (ancho + altura);

            double area = ancho * altura;

            double diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal:F2}");
            Console.ReadKey();
        }
    }
}
