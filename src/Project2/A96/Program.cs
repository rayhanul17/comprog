using System;
class A96
{
    public static void Main(string[] args)
    {
        string players = Console.ReadLine();

        if (players.Contains("1111111") || players.Contains("0000000"))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}