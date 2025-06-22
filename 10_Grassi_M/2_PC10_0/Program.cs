using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de invitados: ");
            int cantInvitados = int.Parse(Console.ReadLine());

            int[] invitados = new int[cantInvitados];

            for (int i = 0; i < invitados.Length; i++)
            {
                bool condic = false;

                while (condic == false)
                {
                    Console.WriteLine("Ingrese la cantidad de comida para el invitado " + (i + 1) + " (puede ser entre 1 y 100)");
                    int comida = int.Parse(Console.ReadLine());

                    if (comida >= 1 && comida <= 100)
                    {
                        condic = true;
                    }
                    invitados[i] = comida;
                }
            }
            int promedio = 0;
            for (int i = 0; i < cantInvitados; i++)
            {
                promedio += invitados[i];
            }
            Console.WriteLine("El promedio por invitado es: " + (promedio / cantInvitados));

        }

    }
}
