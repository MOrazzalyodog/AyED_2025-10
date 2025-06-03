using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandSurvivalGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            int opcion;
            Random rand = new Random();

            Console.WriteLine("Bienvenido a 'Sobreviví una semana en una isla'");

            while (sigueVivo && dia <= 7) 
            {
                Console.WriteLine($"\n--- Día {dia} – ¿Qué querés hacer? ---");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.Write("Elija una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: 
                            hambre += 20;
                            energia -= 15;
                            Console.WriteLine("Buscaste comida.");

                            if (rand.Next(1, 101) <= 30) 
                            {
                                salud -= 15;
                                Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                            }
                            break;

                        case 2:
                            energia += 30;
                            hambre -= 10;
                            Console.WriteLine("Dormiste un rato.");
                            break;

                        case 3: 
                            energia -= 20;
                            hambre -= 15;
                            Console.WriteLine("Exploraste la isla.");

                            if (rand.Next(1, 101) <= 50)
                            {
                                salud += 10;
                                Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                            }
                            break;

                        case 4: 
                            Console.WriteLine("\n--- Estado del Personaje ---");
                            Console.WriteLine($"Salud: {salud}");
                            Console.WriteLine($"Hambre: {hambre}");
                            Console.WriteLine($"Energía: {energia}");
                            Console.WriteLine($"Día: {dia}");
                            break;

                        case 5: 
                            sigueVivo = false;
                            Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
                            break;
                    }

                    if (opcion != 4)
                    {
                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("\nTe desmayaste y no pudiste sobrevivir... Game Over ☠️");
                            sigueVivo = false;
                        }
                        else
                        {
                            dia++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }

            if (sigueVivo && dia > 7)
            {
                Console.WriteLine("\n¡Felicidades! ¡Sobreviviste una semana en la isla!");
            }
            Console.ReadLine();
        }
    }
}