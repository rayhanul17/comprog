int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    Console.ReadLine();
    string s = Console.ReadLine();
    if (s.Length == 5 && s.Contains('T') && s.Contains('u') && s.Contains('i') && s.Contains('m') && s.Contains('r'))
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}