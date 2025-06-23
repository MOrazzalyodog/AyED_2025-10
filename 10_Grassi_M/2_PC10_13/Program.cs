using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("decime la cantidad de alumnos: ");

            int n = int.Parse(Console.ReadLine());

            string[,] Estudiantes = new string[n, 3];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("\nIngrese el nombre del estudiante " + (i + 1));
                Estudiantes[i, 0] = Console.ReadLine();

                Console.WriteLine("\nIngrese la edad del estudiante " + (i + 1));
                Estudiantes[i, 1] = Console.ReadLine();

                Console.WriteLine("\nIngrese la nota del estudiante " + (i + 1));
                Estudiantes[i, 2] = Console.ReadLine();
            }

            Console.WriteLine("\n\nNombre|Edad|Nota|");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n {0}\t {1}\t{2}", Estudiantes[i, 0], Estudiantes[i, 1], Estudiantes[i, 2]);
            }



            Console.ReadKey();
        }
    }
}
