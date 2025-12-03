using Common;
using System.IO;

var size = 100;

var prev = -1;
var location = 50;

var password = 0;
var password2 = 0;

foreach (var line in File.ReadAllLines(Input.GetInputPath(1, true)))
{
    Console.WriteLine(line);

    var dir = line[0];
    var amt = int.Parse(line[1..]);
    
    var delta = (amt % size) * (dir == 'L' ? -1 : 1);
    password2 += amt / 100;
    Console.WriteLine(amt / 100);

    prev = location;
    location += delta;

    if (location < 0)
    {
        location += size;
        if (prev != 0 && location != 0)
        {
            password2++;
        }
    }
    else if (location > size - 1)
    {
        location -= size;
        if (prev != 0 && location != 0)
        {
            password2++;
        }
    }
    
    if (location == 0)
    {
        password++;
        password2++;
    }

    Console.WriteLine(location);
    Console.WriteLine(password2);
    Console.WriteLine("---");
}

Console.WriteLine(password);
Console.WriteLine(password2);