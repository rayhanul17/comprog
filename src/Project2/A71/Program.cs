using System;
public class A71
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] lines = new string[n];
        string word;

        for (int i = 0; i < n; i++)
        {
            lines[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            if (lines[i].Length <= 10)
                Console.WriteLine(lines[i]);
            else
                Console.WriteLine(lines[i].Substring(0, 1) + (lines[i].Length - 2) + lines[i].Substring(lines[i].Length - 1, 1));
        }
    }
}



