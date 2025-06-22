using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            int minimo = 1;
            int maximo = 100;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(minimo, maximo + 1);
                }
            }

            Console.WriteLine("\nMatriz con valores aleatorios:");
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
