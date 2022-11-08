using System;
public class A935
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n / 2; i++)
            if (n % i == 0)
                count++;
        Console.WriteLine(count);
    }
}
