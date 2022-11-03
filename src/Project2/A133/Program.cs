using System;
class A133
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine();
        if (line.Contains("H") || line.Contains("Q") || line.Contains("9"))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}