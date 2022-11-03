using System;

public class B200
{
    public static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine());
        string[] items = Console.ReadLine().Split(' ');
        decimal sum = 0;
        int i = 0;

        foreach (string item in items)
            sum += int.Parse(item);

        Console.WriteLine(sum/total);
    }
}