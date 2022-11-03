using System;

public class A266
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string stones = Console.ReadLine();
        char stone1, stone2;
        int count = 0;

        for (int i = 0; i < n - 1; i++)
        {
            stone1 = stones[i];
            stone2 = stones[i + 1];

            if (stone1 == stone2)
                count++;

        }
        Console.WriteLine(count);
    }

}