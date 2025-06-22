using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de productos vendidos: ");
            int cantProduc = int.Parse(Console.ReadLine());

            int[] productos = new int[cantProduc];

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Ingrese el valor del producto numero {0}: ", i + 1);
                productos[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < productos.Length; i++)
            {
                for (int j = 0; j < productos.Length - 1; j++)
                {
                    if (productos[j] < productos[j + 1])
                    {
                        int temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("El valor del producto {0} ordenado es: {1}", i + 1, productos[i]);
            }


            Console.ReadKey();
        }
    }
}
