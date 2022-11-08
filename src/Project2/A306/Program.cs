using System;
public class A306
{
    public static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int candies = int.Parse(line[0]);
        int friends = int.Parse(line[1]);
        int x = friends - (candies - (friends * (candies / friends)));

        if (candies % friends == 0)
        {
            for (int i = 0; i < friends; i++)
                Console.Write($"{candies / friends} ");
        }
        else
        {
            for (int i = 1; i <= friends; i++)
            {
                if (i <= x)
                    Console.Write($"{candies / friends } ");
                else
                    Console.Write($"{candies / friends + 1} ");
            }
        }
    }
}
