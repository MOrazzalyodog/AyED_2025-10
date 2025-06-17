using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al torneo de Galaxy Quest de Pixel Dreams!");

            int numberOfParticipants;
            while (true)
            {
                Console.Write("Por favor, ingrese la cantidad de participantes en el torneo: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numberOfParticipants) && numberOfParticipants > 0)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
                }
            }

            List<int> scores = new List<int>();

            for (int i = 0; i < numberOfParticipants; i++)
            {
                int score;
                while (true)
                {
                    Console.Write($"Ingrese el puntaje del participante {i + 1}: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out score) && score >= 0)
                    {
                        scores.Add(score);
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero no negativo.");
                    }
                }
            }

            scores.Sort((a, b) => b.CompareTo(a)); 

            Console.WriteLine("\n--- Resultados del Torneo Galaxy Quest ---");

            Console.WriteLine("Puntajes ordenados (de mayor a menor):");
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {scores[i]}");
            }

            if (scores.Count > 0)
            {
                Console.WriteLine($"\n¡Felicidades al primer lugar con un puntaje de: {scores[0]}!");
                Console.WriteLine($"El último lugar obtuvo un puntaje de: {scores[scores.Count - 1]}");
            }
            else
            {
                Console.WriteLine("No se ingresaron puntajes para el torneo.");
            }

            Console.WriteLine("\n¡Gracias por participar en el torneo!");
            Console.ReadKey(); 
        }
    }
    

}
