using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool encontrado = false;

            Console.Write("Ingrese la cantidad de objetos a analizar: ");
            int cantidadObjetos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor mínimo para filtrar los objetos: ");
            int valorMinimo = int.Parse(Console.ReadLine());

            int[] valoresObjetos = new int[cantidadObjetos];

            for (int i = 0; i < cantidadObjetos; i++)
            {
                Console.Write("Ingrese el valor del objeto #{0}: ", (i + 1));
                valoresObjetos[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Posiciones de objetos con valor mayor al mínimo:");


            for (int i = 0; i < cantidadObjetos; i++)
            {
                if (valoresObjetos[i] > valorMinimo)
                {
                    Console.WriteLine("Objeto en posición {0} (valor: {1})", (i + 1), valoresObjetos[i]);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron objetos con valor mayor al especifico");
            }
        }
    }
}
