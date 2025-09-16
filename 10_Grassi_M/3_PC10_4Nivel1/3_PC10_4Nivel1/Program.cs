using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
            bool ok = Level1.ValidateAccessKey("WD-700000")
                      && !Level1.ValidateAccessKey("WD-123123")
                      && !Level1.ValidateAccessKey("WX-000007")
                      && !Level1.ValidateAccessKey("WD-00007");
            if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
            else Console.WriteLine("🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level1
    {
        // Debe devolver true solo si:
        // - Empieza por "WD-"
        // - Luego hay exactamente 6 dígitos
        // - La suma de esos 6 dígitos es múltiplo de 7
        public static bool ValidateAccessKey(string key, int suma = 0)
        {

            // TODO: implementar


            if (!key.StartsWith("WD-"))
                return false;

            if (key.Length != 9)
                return false;
            for (int i = 3; i < 9; i++)
            {
                char c = key[i];

                if (!char.IsDigit(c))
                    return false;

                suma += c - '0';
            }
            if (suma % 7 != 0)
            {
                return false;
            }

            return true;




        }
    }
}

