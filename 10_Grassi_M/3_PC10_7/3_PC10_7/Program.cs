using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_7
{
    class Program
    {
        static string[,] personaje = new string[20, 5];
        static int contadorp = 0;
        static void Main(string[] args)
        {
            int opcion;
            bool continuar = true;

            Console.WriteLine("Borderlands MVM");

            while (continuar)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Nuevo Personaje");
                Console.WriteLine("2. Consultar Personaje por Nombre");
                Console.WriteLine("3. Modificar Personaje");
                Console.WriteLine("4. Eliminar Personaje");
                Console.WriteLine("5. Mostrar Todos los Personajes");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            CrearPers();

                            break;

                        case 2:
                            Buscador();
                            break;

                        case 3:
                            ModPers();
                            break;

                        case 4:
                            BorrarPers();
                            break;
                        case 5:
                            MostrarPers();
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


            Console.WriteLine(CrearPers());
            Buscador();
            Console.ReadKey();
        }
        static string CrearPers()
        {
            bool esheroe;


            Console.Clear();    
            Console.WriteLine("escriba el nombre del nuevo personaje");
            string nombre = Console.ReadLine();
            Console.WriteLine("escriba la saga del personaje");
            string saga = Console.ReadLine();
            Console.WriteLine("escriba la fuerza del personaje");
            string fuerza = Console.ReadLine();
            Console.WriteLine("escriba la defensa del personaje");
            string defensa = Console.ReadLine();
            Console.WriteLine("escriba  s  si  es heroe el personaje, sino escriba n ");
            string s = Console.ReadLine();




            if (s == "s")
            {
                esheroe = true;
            }
            else
            {
                esheroe = false;
            }

            personaje[contadorp, 0] = nombre;
            personaje[contadorp, 1] = saga;
            personaje[contadorp, 2] = fuerza;
            personaje[contadorp, 3] = defensa;
            personaje[contadorp, 4] = esheroe.ToString();

            if (contadorp > 20)
            {
                Console.WriteLine("no podes crear mas personajes");
            }
            else
            {
                contadorp++;
            }

            return "El personaje ha sido agregado";
        }
        static string Buscador()
        {

            Console.WriteLine("Buscar personaje por nombre:");
            string nombreBuscado = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < contadorp; i++)
            {
                if (personaje[i, 0] == nombreBuscado)
                {
                    Console.WriteLine($"Nombre: {personaje[i, 0]}");
                    Console.WriteLine($"Saga: {personaje[i, 1]}");
                    Console.WriteLine($"Fuerza: {personaje[i, 2]}");
                    Console.WriteLine($"Defensa: {personaje[i, 3]}");
                    Console.WriteLine($"¿Héroe?: {personaje[i, 4]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Personaje no encontrado.");
            }
            return "Personaje buscado";
        }
        static string ModPers()
        {

            for (int i = 0; i < contadorp; i++)
            {
                Console.Clear();
                Console.WriteLine($"Nombre: {personaje[i, 0]}");
                Console.WriteLine($"Saga: {personaje[i, 1]}");
                Console.WriteLine($"Fuerza: {personaje[i, 2]}");
                Console.WriteLine($"Defensa: {personaje[i, 3]}");
                Console.WriteLine($"¿Héroe?: {personaje[i, 4]}");

            }
            Console.WriteLine("\n elegí el personaje que le queres cambiar las caracteristicas:");
            string elec =  Console.ReadLine();

            for (int j = 0; j < contadorp; j++)
            {


                if (personaje[j, 0] == elec)
                {
                    Console.WriteLine("¿A cuanto queres cambiar la fuerza?");
                    personaje[j, 2] = Console.ReadLine();
                    Console.WriteLine("¿A cuanto queres cambiar la defensa?");
                    personaje[j, 3] = Console.ReadLine();
                    Console.WriteLine("Es heroe?(s/n)");
                    personaje[j, 4] = Console.ReadLine();
                }
            }


            return "personaje actualizado";

        }
        static string BorrarPers()
        {
            Console.Clear();
            for (int i = 0; i < contadorp; i++)
            {
                
                Console.WriteLine($"\nNombre: {personaje[i, 0]}");
                Console.WriteLine($"Saga: {personaje[i, 1]}");
                Console.WriteLine($"Fuerza: {personaje[i, 2]}");
                Console.WriteLine($"Defensa: {personaje[i, 3]}");
                Console.WriteLine($"¿Héroe?: {personaje[i, 4]}");

            }
            
            Console.WriteLine("\n Que personaje queres borrar)");
            string Borrar = Console.ReadLine();
              
            for (int k = 0; k < contadorp; k++)
            {
                if (personaje[k, 0] == Borrar)
                {
                    personaje[k, 0] = "";
                    personaje[k, 1] = "";
                    personaje[k, 2] = "";
                    personaje[k, 3] = "";
                    personaje[k, 4] = "";
                    contadorp -= 1;
                }
            }  


            return "personaje borrado";
        }
        static string MostrarPers()
        {
            Console.Clear();
            for (int i = 0; i < contadorp; i++)
            {

                


                    
                    Console.WriteLine($"\nNombre: {personaje[i, 0]}");
                    Console.WriteLine($"Saga: {personaje[i, 1]}");
                    Console.WriteLine($"Fuerza: {personaje[i, 2]}");
                    Console.WriteLine($"Defensa: {personaje[i, 3]}");
                    Console.WriteLine($"¿Héroe?: {personaje[i, 4]}");

                
            }
            return "personaje mostrado";
        }

    }
}