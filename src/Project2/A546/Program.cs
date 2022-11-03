using System;
public class A546
{
    public static void Main(string[] args)
    {
        string inputs = Console.ReadLine();
        string[] numbers = inputs.Split(" ");
        int total_price = 0;

        int banana_price = int.Parse(numbers[0]);
        int money_have = int.Parse(numbers[1]);
        int banana_need = int.Parse(numbers[2]);

        for (int i = 1; i <= banana_need; i++)
        {
            total_price = total_price + banana_price * i;
        }

        if (total_price < money_have)
            Console.WriteLine(0);
        else
            Console.WriteLine(total_price - money_have);
    }
}