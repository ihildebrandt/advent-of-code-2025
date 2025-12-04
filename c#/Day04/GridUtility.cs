using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day04
{
    internal static class GridUtility
    {
        public static bool CanAccess(char[][] grid, int x, int y)
        {
            var hit = 0;
            var accessible = true;

            for (var xd = -1; xd <= 1; xd++)
            {
                if (x == 0 && xd == -1) continue;
                if (x == grid[0].Length - 1 && xd == 1) continue;

                for (var yd = -1; yd <= 1; yd++)
                {
                    if (y == 0 && yd == -1) continue;
                    if (y == grid.Length - 1 && yd == 1) continue;

                    if (xd == 0 && yd == 0) continue;

                    if (grid[y + yd][x + xd] == '@') hit++;

                    if (hit >= 4) accessible = false;
                }
            }

            return accessible;
        }
    }
}
