using System;

public class A479
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = 0;

        int[] sum = new int[6];
        sum[0] = a + b + c;
        sum[1] = (a + b) * c;
        sum[2] = (a * b) + c;
        sum[3] = a * (b + c);
        sum[4] = a + (b * c);
        sum[5] = a * b * c;

        foreach (int i in sum)
            if (max < i)
                max = i;

        Console.WriteLine(max);
    }
}