using System;

public class A318
{
    public static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        long n = Convert.ToInt64(line[0]);
        long k = Convert.ToInt64(line[1]);
        long even_nums, odd_nums;
        if (n % 2 == 0)
        {
            even_nums = odd_nums = n / 2;
        }

        else
        {
            even_nums = n / 2;
            odd_nums = n / 2 + 1;
        }

        if (k <= odd_nums)
        {
            Console.WriteLine(k * 2 - 1);
        }
        else
        {
            Console.WriteLine((k - odd_nums) * 2);
        }

    }
}