using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_77
{
    class Program
    {
        static string[,] personaje = new string[20, 5];
        static int contadorp = 0;
        static void Main(string[] args)
        {
            

            Console.WriteLine(CrearPers());
            Buscador();
            Console.ReadKey();
        }
        static string CrearPers()
        {
            bool esheroe;


            
            Console.WriteLine("escriba el nombre del nuevo personaje");
            string nombre = Console.ReadLine();
            Console.WriteLine("escriba la saga dell personaje");
            string saga = Console.ReadLine();
            Console.WriteLine("escriba la fuerza del personaje");
            string fuerza = Console.ReadLine();
            Console.WriteLine("escriba la defensa del personaje");
            string defensa = Console.ReadLine();
            Console.WriteLine("escriba  s  si  es heroe el personaje, sino escriba n ");
            string s = Console.ReadLine() ;
            



            if (s == "s" )
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

            return "El personaje ha sido agregado" ;
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
    }
}
