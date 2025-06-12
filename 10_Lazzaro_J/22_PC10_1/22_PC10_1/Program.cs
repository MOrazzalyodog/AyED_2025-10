using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PC10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al asistente de carrera del Rayo McQueen!");

            int cantidadVueltas;

            Console.Write("Por favor, ingresa la cantidad de vueltas que completó el Rayo McQueen: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadVueltas) || cantidadVueltas <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero positivo para la cantidad de vueltas.");
            }

            double[] tiemposVueltas = new double[cantidadVueltas];

            for (int i = 0; i < cantidadVueltas; i++)
            {
                Console.Write($"Ingresa el tiempo de la vuelta {i + 1} en segundos: ");
                while (!double.TryParse(Console.ReadLine(), out tiemposVueltas[i]) || tiemposVueltas[i] <= 0)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingresa un número positivo para el tiempo.");
                }
            }

            double tiempoTotalCarrera = 0;
            foreach (double tiempo in tiemposVueltas)
            {
                tiempoTotalCarrera += tiempo;
            }

            double promedioTiempoPorVuelta = tiempoTotalCarrera / cantidadVueltas;

            double mejorVuelta = tiemposVueltas[0];
            int numeroMejorVuelta = 1;
            for (int i = 1; i < cantidadVueltas; i++)
            {
                if (tiemposVueltas[i] < mejorVuelta)
                {
                    mejorVuelta = tiemposVueltas[i];
                    numeroMejorVuelta = i + 1;
                }
            }

            Console.WriteLine("\n--- Estadísticas de la Carrera ---");
            Console.WriteLine($"Tiempo total de la carrera: {tiempoTotalCarrera:F2} segundos");
            Console.WriteLine($"Promedio de tiempo por vuelta: {promedioTiempoPorVuelta:F2} segundos");
            Console.WriteLine($"La mejor vuelta fue la número {numeroMejorVuelta} con un tiempo de: {mejorVuelta:F2} segundos");

            Console.WriteLine("\n¡Gracias por usar el asistente del Rayo McQueen!");
            Console.ReadKey();
        }
    
    }
}
