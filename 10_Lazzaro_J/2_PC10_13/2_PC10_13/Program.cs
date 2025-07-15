using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos estudiantes tenes?");
            int n = int.Parse(Console.ReadLine());
            string[,] matriz = new string[n, 3];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Cual es el nombre del estudiante " + (i + 1) + "?");
                matriz[i, 0] = Console.ReadLine();
                Console.Write("Cuantos años tiene el estudiante " + (i + 1) + "?");
                matriz[i, 1] = Console.ReadLine();
                Console.Write("Cual es su calificacion del estudiante " + (i + 1) + "?");
                matriz[i, 2] = Console.ReadLine();
            }
            Console.WriteLine("Nombre" + "\t" + "edad" + "\t" + "calificacion");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, 0] + "\t" + matriz[i, 1] + "\t" + matriz[i, 2] + "\t");

            }
        }
    }
}
