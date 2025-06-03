using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC10_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jugador1";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;

            int opcion;
            bool continuar = true;

            Console.WriteLine("Bienvenido al programa de opciones.");

            while (continuar)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Mostrar estado del jugador");
                Console.WriteLine("2. Encontrar espada mágica");
                Console.WriteLine("3. Pelear contra un enemigo");
                Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
                Console.WriteLine("5. Salir del juego)");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\n--- Estado del Jugador ---");
                            Console.WriteLine($"Nombre: {nombre}");
                            Console.WriteLine($"Salud: {salud}");
                            Console.WriteLine($"Monedas: {monedas}");
                            Console.WriteLine($"Enemigos Derrotados: {enemigosDerrotados}");
                            Console.WriteLine($"Tiene Espada: {(tieneEspada ? "Sí" : "No")}");
                            break;

                        case 2:
                            if (tieneEspada)
                            {
                                Console.WriteLine("¡Ya tenés la espada mágica!");
                            }
                            else
                            {
                                tieneEspada = true;
                                Console.WriteLine("¡Encontraste la espada mágica!");
                            }
                            break;

                        case 3:
                            if (tieneEspada)
                            {
                                salud -= 10;
                                enemigosDerrotados++;
                                Console.WriteLine($"¡Ganaste la batalla! Salud -10. Salud actual: {salud}");
                            }
                            else
                            {
                                salud -= 30;
                                Console.WriteLine($"¡Fue una pelea dura sin espada! Salud -30. Salud actual: {salud}");
                            }
                            // Check for game over if health drops to 0 or below
                            if (salud <= 0)
                            {
                                Console.WriteLine("\n¡Tu salud ha llegado a 0! Game Over.");
                                continuar = false;
                            }
                            break;

                        case 4:
                            int costoPocion = 20;
                            if (monedas >= costoPocion)
                            {
                                monedas -= costoPocion;
                                salud += 20;
                                Console.WriteLine($"Usaste una poción. +20 de salud. Monedas restantes: {monedas}. Salud actual: {salud}");
                            }
                            else
                            {
                                Console.WriteLine("No tenés suficientes monedas para comprar la poción.");
                            }
                            break;

                        case 5:
                            continuar = false;
                            Console.WriteLine("¡Gracias por jugar!");
                            break;


                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }
        }
    }
}