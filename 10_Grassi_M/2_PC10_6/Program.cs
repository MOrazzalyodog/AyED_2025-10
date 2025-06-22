using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de candidatos: ");
            int cantidadCandidatos = int.Parse(Console.ReadLine());

            int[] puntajes = new int[cantidadCandidatos];

            for (int i = 0; i < cantidadCandidatos; i++)
            {
                Console.Write("Ingrese el puntaje del candidato #{0}: ", (i + 1));
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            int t;
            for (int i = 1; i < puntajes.Length; i++)
            {
                for (int j = puntajes.Length - 1; j >= i; j--)
                {
                    if (puntajes[j - 1] > puntajes[j])
                    {
                        t = puntajes[j - 1];
                        puntajes[j - 1] = puntajes[j];
                        puntajes[j] = t;
                    }
                }
            }

            Console.WriteLine("Puntajes ordenados de menor a mayor:");
            for (int i = 0; i < cantidadCandidatos; i++)
            {
                Console.WriteLine(puntajes[i]);
            }

            Console.Write("Ingrese un número para filtrar múltiplos: ");
            int numeroFiltro = int.Parse(Console.ReadLine());


            Console.WriteLine("Puntajes múltiplos de {0}:", numeroFiltro);
            bool seEncontraron = false;

            for (int i = 0; i < cantidadCandidatos; i++)
            {
                if (puntajes[i] % numeroFiltro == 0)
                {
                    Console.WriteLine(puntajes[i]);
                    seEncontraron = true;
                }
            }

            if (!seEncontraron)
            {
                Console.WriteLine("No se encontraron puntajes que sean múltiplos del número indicado.");
            }

        }
    }
}
