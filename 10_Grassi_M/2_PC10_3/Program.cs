using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de participantes en el torneo");
            int cantPart = int.Parse(Console.ReadLine());

            int[] participantes = new int[cantPart];

            Console.WriteLine("Ingrese los puntajes de los participantes ");

            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine("Ingrese el puntaje del participante {0}: ", i + 1);
                participantes[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < participantes.Length; i++)
            {
                for (int j = 0; j < participantes.Length - 1; j++)
                {
                    if (participantes[j] < participantes[j + 1])
                    {
                        int temp = participantes[j];
                        participantes[j] = participantes[j + 1];
                        participantes[j + 1] = temp;
                    }
                }
            }


            Console.WriteLine();

            Console.WriteLine("Los puntajes de mayor a menor son: ");

            for (int i = 0; i < participantes.Length; i++)
            {

                Console.WriteLine("el puntaje numero {0} es: {1} ", i + 1, participantes[i]);

            }

            Console.ReadKey();
        }
    }
}
