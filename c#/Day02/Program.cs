using Common;
using System.Diagnostics;

var groups = File.ReadAllLines(Input.GetInputPath(2, true))
    .SelectMany(line => line.Split(',').Select(group => group.Split('-')).ToArray());

var invalid = new List<long>();
foreach (var group in groups)
{
    var min = long.Parse(group[0]);
    var max = long.Parse(group[1]);

    for (var i = min; i < max + 1; i++)
    {
        var s = i.ToString();

        for (var j = s.Length; j >= 2; j--) 
        {
            if (s.Length % j != 0) continue;

            var parts = new List<string>();
            var d = s.Length / j;

            for (var k = 0; k < s.Length; k += d)
            {
                parts.Add(s[k..(k + d)]);
            }

            if (parts.Any(p => p != parts[0])) continue;
            invalid.Add(i);
            break;
        }
    }
}

Debugger.Break();
Console.WriteLine(invalid.Sum());