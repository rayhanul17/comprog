using System;

public class A379
{
    public static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int candle = int.Parse(line[0]);
        int make1 = int.Parse(line[1]);
        int num = candle;
        int den = 0;

        while(num >= make1)
        {
            den = num % make1;
            num = num / make1;
            candle = candle + num;
            num = num + den;
        }
        Console.WriteLine(candle);
    }
}