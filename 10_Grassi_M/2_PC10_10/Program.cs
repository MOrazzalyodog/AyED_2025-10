using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[n, n];
            int[,] matrizB = new int[n, n];
            int[,] matrizSuma = new int[n, n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizA[i, j] = rnd.Next(1, 51);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizB[i, j] = rnd.Next(1, 51);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizSuma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("\nMatriz A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz B:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz Suma (A + B):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizSuma[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
