using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Ingrese el valor de fila y columna: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    matriz[f, c] = rand.Next(1, 81);
                }
            }
            Console.WriteLine("Matriz N°1: ");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Diagonal: ");
            int[] diagonal = new int[n];
            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matriz[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonal[i] + "\t");
            }


            Console.ReadKey();
        }
    }
}
