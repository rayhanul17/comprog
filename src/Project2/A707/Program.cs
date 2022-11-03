using System;
public class A707
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine().Split(' ')[0]);
        string colors = string.Empty;

        for(int i = 0; i < num; i++)
            colors += Console.ReadLine();

        if (colors.Contains('C') || colors.Contains('M') || colors.Contains('Y'))
            Console.WriteLine("#Color");
        else
            Console.WriteLine("#Black&White");
    }
}