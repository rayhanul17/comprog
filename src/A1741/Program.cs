int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var sizes = Console.ReadLine().Split().ToArray();
    var a = sizes[0];
    var b = sizes[1];
    var ax = a.Count(e => e == 'X');
    var bx = b.Count(e => e == 'X');

    if (a[^1] == b[^1])
    {
        if (a[^1] == 'L')
            Console.WriteLine(ax < bx ? '<' : ax == bx ? '=' : '>');
        else
            Console.WriteLine(ax < bx ? '>' : ax == bx ? '=' : '<');
    }
    else if (a[^1] == 'L' && (b[^1] == 'M' || b[^1] == 'S'))
        Console.WriteLine('>');
    else if (a[^1] == 'M' && (b[^1] == 'S'))
        Console.WriteLine('>');
    else
        Console.WriteLine('<');
}