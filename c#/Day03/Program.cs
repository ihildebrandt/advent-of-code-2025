
using Common;
using System.Diagnostics;

var banks = File.ReadAllLines(Input.GetInputPath(3, true))
    .Select(line => line.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray())
    .ToArray();

var batteries = 12;
var voltage = new List<long>();

foreach (var bank in banks)
{
    Console.WriteLine($"Starting Bank: {string.Join("",bank)}");

    var on = new int[batteries];
    var startIndex = 0;

    for (var position = 0; position < batteries; position++)
    {
        var delta = batteries - position;
        Console.WriteLine($"Starting looking for position {position} value at {startIndex} with delta {delta}");

        for (var value = 9; value > 0; value--)
        {
            for (var i = startIndex; i < bank.Length - delta + 1; i++)
            {
                if (bank[i] == value)
                {
                    Console.WriteLine($"Found value {value} at index {i}");
                    on[position] = bank[i];
                    startIndex = i + 1;
                    goto End;
                }
            }

            Console.WriteLine($"Did not find value {value}");
        }

    End:
        Console.WriteLine();
    }

    voltage.Add(long.Parse(string.Join("", on)));
}

Console.WriteLine(voltage.Sum());

Debugger.Break();