using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfProducts;
            while (true)
            {
                Console.Write("Por favor, ingresa la cantidad de productos vendidos durante el Hot Sale: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numberOfProducts) && numberOfProducts > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero positivo.");
                }
            }

            List<double> prices = new List<double>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                double price;
                while (true)
                {
                    Console.Write($"Ingresa el precio del producto {i + 1}: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out price) && price >= 0)
                    {
                        prices.Add(price);
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingresa un número decimal no negativo.");
                    }
                }
            }

            Console.WriteLine("\n--- Análisis de Precios del Hot Sale ---");

            if (prices.Count > 0)
            {
                double highestPrice = prices.Max();
                double lowestPrice = prices.Min();

                Console.WriteLine($"El precio más alto registrado durante el Hot Sale fue: ${highestPrice:F2}");
                Console.WriteLine($"El precio más bajo registrado durante el Hot Sale fue: ${lowestPrice:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron precios de productos para el análisis.");
            }

            Console.WriteLine("\n¡Análisis completado!");
            Console.ReadKey(); 
        }
    }
    
}
