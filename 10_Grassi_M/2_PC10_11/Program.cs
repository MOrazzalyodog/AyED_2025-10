using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrizOriginal = new int[n, n];
            int[,] matrizRotada = new int[n, n];
            Random rnd = new Random();

            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizOriginal[i, j] = rnd.Next(1, 10);
                    Console.Write(matrizOriginal[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizRotada[j, n - 1 - i] = matrizOriginal[i, j];
                }
            }

            Console.WriteLine("\nMatriz rotada 90° en sentido horario:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizRotada[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
