using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenida, Lilo! Vamos a calcular la comida para la fiesta de Stitch.");

            int cantidadInvitados = 0;
            bool entradaValida = false;



            while (!entradaValida)
            {
                Console.Write("Por favor, ingresa la cantidad de invitados aliens (entre 1 y 100): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out cantidadInvitados))
                {
                    if (cantidadInvitados >= 1 && cantidadInvitados <= 100)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La cantidad de invitados debe estar entre 1 y 100. ¡Intenta de nuevo!");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                }
            }

            double sumaComida = 0;

            for (int i = 1; i <= cantidadInvitados; i++)
            {
                int comidaInvitado = 0;
                entradaValida = false;

                while (!entradaValida)
                {
                    Console.Write($"Ingresa la cantidad de comida que consume el invitado #{i} (entre 1 y 100): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out comidaInvitado))
                    {
                        if (comidaInvitado >= 1 && comidaInvitado <= 100)
                        {
                            sumaComida += comidaInvitado;
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("La cantidad de comida debe estar entre 1 y 100. ¡No olvides el apetito alienígena!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                    }
                }
            }


            double promedioComida = sumaComida / cantidadInvitados;
            Console.WriteLine($"\n¡Listo, Lilo! El promedio de comida por invitado es: {promedioComida:F2} unidades.");
            Console.WriteLine("¡Que disfruten la fiesta!");

            Console.ReadKey();
        
    }
    }
}
