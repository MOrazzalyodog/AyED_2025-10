using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int[] diagonal = new int[n];

            Random rnd = new Random();

            Console.WriteLine("\nMatriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rnd.Next(1, 100);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matriz[i, i];
            }

            Console.WriteLine("\nDiagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonal[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
