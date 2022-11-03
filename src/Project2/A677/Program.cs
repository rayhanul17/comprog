using System;
public class A677
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine().Split(' ')[1]);
        int index = 0;
        decimal sum = 0;
        
        string[] line = Console.ReadLine().Split(' ');
        int[] items = new int[line.Length];

        foreach (string item in line)
            items[index++] = int.Parse(item);

        foreach (int item in items)
            sum = sum + Math.Ceiling((decimal)item/number);

        Console.WriteLine((int)sum);
    }
}