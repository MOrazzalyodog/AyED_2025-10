using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al sistema de aprobación de Phineas y Ferb!");

            Console.Write("Ingrese la cantidad de Trabajos Prácticos (TPs): ");
            int numTps = int.Parse(Console.ReadLine());

            List<double> notasTps = new List<double>();
            for (int i = 0; i < numTps; i++)
            {
                Console.Write($"Ingrese la nota del TP #{i + 1}: ");
                notasTps.Add(double.Parse(Console.ReadLine()));
            }

            Console.Write("Ingrese la cantidad de exámenes: ");
            int numExamenes = int.Parse(Console.ReadLine());

            List<double> notasExamenes = new List<double>();
            for (int i = 0; i < numExamenes; i++)
            {
                Console.Write($"Ingrese la nota del examen #{i + 1}: ");
                notasExamenes.Add(double.Parse(Console.ReadLine()));
            }

            double promedioExamenes = notasExamenes.Average();
            Console.WriteLine($"\nEl promedio de los exámenes es: {promedioExamenes:F2}");

            bool apruebaExamenes = promedioExamenes >= 6;

            double porcentajeTpsAprobados = notasTps.Count > 0 ? (double)notasTps.Count(nota => nota >= 6) / notasTps.Count * 100 : 100;
            Console.WriteLine($"Porcentaje de TPs con nota >= 6: {porcentajeTpsAprobados:F2}%");
            bool apruebaTps = porcentajeTpsAprobados >= 75;

            if (apruebaExamenes && apruebaTps)
            {
                Console.WriteLine("\n¡Felicidades! Phineas y Ferb pueden aprobar la materia.");
            }
            else
            {
               
                if (!apruebaExamenes) Console.WriteLine("- El promedio de los exámenes es menor a 6.");
                if (!apruebaTps) Console.WriteLine("- Menos del 75% de los TPs tienen una nota >= 6.");

            }
            Console.ReadKey();
        }
    }
}
