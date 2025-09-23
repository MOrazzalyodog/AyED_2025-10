using System;
using System.Collections.Generic;

namespace BorderlandsMVM
{
    class Program
    {
        static List<Personaje> personajes = new List<Personaje>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("---- MENÚ PRINCIPAL ----");
                Console.WriteLine("1. Crear nuevo personaje");
                Console.WriteLine("2. Consultar personaje por nombre");
                Console.WriteLine("3. Modificar personaje");
                Console.WriteLine("4. Eliminar personaje");
                Console.WriteLine("5. Mostrar todos los personajes");
                Console.WriteLine("6. Salir");
                Console.Write("Elegí una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: CrearPersonaje();
                        break;
                    case 2: ConsultarPersonaje();
                        break;
                    case 3: ModificarPersonaje();
                        break;
                    case 4: EliminarPersonaje();
                        break;
                    case 5: MostrarPersonajes();
                        break;
                    case 6: Console.WriteLine("¡Hasta luego!");
                        break;
                    default: Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresioná una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 6);
        }

        // Estructura de un personaje
        class Personaje
        {
            public string Nombre;
            public string Faccion;
            public int Fuerza;
            public int Defensa;
            public bool EsHeroe;
        }

        // 1. Crear personaje
        static void CrearPersonaje()
        {
            if (personajes.Count >= 20)
            {
                Console.WriteLine(" No se pueden agregar más de 20 personajes.");
                return;
            }

            Console.Write("Nombre del personaje: ");
            string nombre = Console.ReadLine();

            // Validar si ya existe
            foreach (var p in personajes)
            {
                if (p.Nombre.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine(" Ya existe un personaje con ese nombre.");
                    return;
                }
            }

            Console.Write("Saga/Facción: ");
            string faccion = Console.ReadLine();

            Console.Write("Fuerza (número): ");
            int fuerza = int.Parse(Console.ReadLine());

            Console.Write("Defensa (número): ");
            int defensa = int.Parse(Console.ReadLine());

            Console.Write("¿Es un héroe? (true/false): ");
            bool esHeroe = bool.Parse(Console.ReadLine());

            Personaje nuevo = new Personaje
            {
                Nombre = nombre,
                Faccion = faccion,
                Fuerza = fuerza,
                Defensa = defensa,
                EsHeroe = esHeroe
            };

            personajes.Add(nuevo);
            Console.WriteLine(" Personaje creado con éxito.");
        }

        // 2. Consultar personaje
        static void ConsultarPersonaje()
        {
            Console.Write("Nombre del personaje a buscar: ");
            string nombre = Console.ReadLine();

            foreach (var p in personajes)
            {
                if (p.Nombre.ToLower() == nombre.ToLower())
                {
                    MostrarDatos(p);
                    return;
                }
            }

            Console.WriteLine(" No se encontró el personaje.");
        }

        // 3. Modificar personaje
        static void ModificarPersonaje()
        {
            Console.Write("Nombre del personaje a modificar: ");
            string nombre = Console.ReadLine();

            foreach (var p in personajes)
            {
                if (p.Nombre.ToLower() == nombre.ToLower())
                {
                    Console.Write("Nueva Fuerza: ");
                    p.Fuerza = int.Parse(Console.ReadLine());

                    Console.Write("Nueva Defensa: ");
                    p.Defensa = int.Parse(Console.ReadLine());

                    Console.WriteLine("Personaje modificado.");
                    return;
                }
            }

            Console.WriteLine(" No se encontró el personaje.");
        }

        // 4. Eliminar personaje
        static void EliminarPersonaje()
        {
            Console.Write("Nombre del personaje a eliminar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < personajes.Count; i++)
            {
                if (personajes[i].Nombre.ToLower() == nombre.ToLower())
                {
                    personajes.RemoveAt(i);
                    Console.WriteLine(" Personaje eliminado.");
                    return;
                }
            }

            Console.WriteLine(" No se encontró el personaje.");
        }

        // 5. Mostrar todos los personajes
        static void MostrarPersonajes()
        {
            if (personajes.Count == 0)
            {
                Console.WriteLine(" No hay personajes cargados.");
                return;
            }

            // Ordenar alfabéticamente por nombre
            personajes.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));

            Console.WriteLine("\n Lista de personajes:");
            foreach (var p in personajes)
            {
                MostrarDatos(p);
                Console.WriteLine("---------------------------");
            }
        }

        // Función para mostrar los datos de un personaje
        static void MostrarDatos(Personaje p)
        {
            Console.WriteLine($"Nombre: {p.Nombre}");
            Console.WriteLine($"Saga/Facción: {p.Faccion}");
            Console.WriteLine($"Fuerza: {p.Fuerza}");
            Console.WriteLine($"Defensa: {p.Defensa}");
            Console.WriteLine($"¿Es Héroe?: {(p.EsHeroe ? "Sí" : "No")}");
        }
    }
}
