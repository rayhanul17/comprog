using System;

public class A617
{
    public static void Main(string[] args)
    {
        int distance = int.Parse(Console.ReadLine());
        if (distance <= 5)
            Console.WriteLine(1);
        else if (distance % 5 == 0)
            Console.WriteLine(distance / 5);
        else
            Console.WriteLine(distance / 5 + 1);
    }
}