
using Common;
using Day04;

var lines = File.ReadAllLines(Input.GetInputPath(4, false))
    .Select(line => line.ToCharArray())
    .ToArray();
var width = lines[0].Length;

var access = new List<(int x,int y)>();
var total = 0;

do
{
    foreach (var coord in access)
    {
        lines[coord.y][coord.x] = 'x';
    }
    access.Clear();

    for (var y = 0; y < lines.Length; y++)
    {
        for (var x = 0; x < width; x++)
        {
            if (lines[y][x] != '@') continue;

            if (GridUtility.CanAccess(lines, x, y))
            {
                Console.WriteLine($"Accessible: ({x},{y})");
                access.Add((x, y));
            }
        }
    }

    total += access.Count;
} while (access.Any());

Console.WriteLine(total);