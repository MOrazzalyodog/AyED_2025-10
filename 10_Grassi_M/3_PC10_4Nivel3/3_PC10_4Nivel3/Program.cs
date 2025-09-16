using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC10_4Nivel3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
            bool ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level3
    {
        public static int CountAdjacent(int[,] grid, int row, int col)
        {
            int count = 0;
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            if (row > 0 && grid[row - 1, col] == 1)
                count++;
            if (row < rows - 1 && grid[row + 1, col] == 1)
                count++;
            if (col > 0 && grid[row, col - 1] == 1)
                count++;
            if (col < cols - 1 && grid[row, col + 1] == 1)
                count++;

            return count;
        }
    }
}
