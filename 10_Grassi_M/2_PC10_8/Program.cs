using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de columnas: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            Console.WriteLine("\nMatriz inicializada con ceros:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
