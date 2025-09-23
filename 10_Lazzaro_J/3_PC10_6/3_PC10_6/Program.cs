using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
            // 1) Generar mano aleatoria
            string[] mano = GenerarManoAleatoria();
            // 2) Determinar tipo de mano
            string tipo = TipoDeMano(mano);
            // 3) Calcular puntaje base


            int basePts = PuntajeBase(mano);
            // 4) Obtener multiplicador
            double mult = Multiplicador(tipo);
            // 5) Calcular puntaje final
            double total = basePts * mult;
            // 6) Aplicar jokers
            bool jokerX2 = true;
            bool jokerMas10 = true;
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // 7) Mostrar resumen final
            MostrarResumen(mano, tipo, basePts, mult, total);
            Console.ReadKey();
        }
        // ⚠️ Todas las funciones que se llaman en el Main
        // deben ser creadas acá abajo por ustedes.
        static string[] GenerarManoAleatoria()
    {
        string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
        string[] palos = { "H", "D", "C", "S" };

        Random rnd = new Random();
        string[] mano = new string[5];

        for (int i = 0; i < 5; i++)
        {
            string rango = rangos[rnd.Next(rangos.Length)];
            string palo = palos[rnd.Next(palos.Length)];
            mano[i] = rango + palo;
        }

        return mano;
    }


        static string TipoDeMano(string[] mano)
        {
            Dictionary<string, int> contadorRangos = new Dictionary<string, int>();

            foreach (string carta in mano)
            {
                string rango = carta.Substring(0, 1);
                if (!contadorRangos.ContainsKey(rango))
                    contadorRangos[rango] = 0;

                contadorRangos[rango]++;
            }

            var cantidades = contadorRangos.Values.OrderByDescending(x => x).ToList();

            if (cantidades.Contains(4))
                return "Poker";
            else if (cantidades.Contains(3) && cantidades.Contains(2))
                return "Full";
            else if (cantidades.Contains(3))
                return "Trio";
            else if (cantidades.Count(x => x == 2) == 1)
                return "Par";
            else
                return "Nada";
        }


        static int PuntajeBase(string[] mano)
        {
            Dictionary<string, int> valores = new Dictionary<string, int>()
        {
            { "A", 14 },
            { "K", 13 },
            { "Q", 12 },
            { "J", 11 },
            { "T", 10 },
            { "9", 9 },
            { "8", 8 },
            { "7", 7 },
            { "6", 6 },
            { "5", 5 },
            { "4", 4 },
            { "3", 3 },
            { "2", 2 }
        };

            int suma = 0;

            foreach (string carta in mano)
            {
                string rango = carta.Substring(0, 1);
                suma += valores[rango];
            }

            return suma;
        }

        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Par":
                    return 1.5;
                case "Trio":
                    return 2.5;
                case "Full":
                    return 3.5;
                case "Poker":
                    return 4.0;
                default:
                    return 1.0;
            }
        }


        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2)
                puntaje *= 2;
            if (mas10)
                puntaje += 10;

            return puntaje;
        }

        // 6) Mostrar Resumen
        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.WriteLine("Mano: " + string.Join(" ", mano.Select(c => $"[{c}]")));
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Total (con Jokers): " + total);
        }



    }
}
