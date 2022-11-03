using System;

class A977
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string[] numbers = line.Split(' ');

        int n1 = int.Parse(numbers[0]);
        int n2 = int.Parse(numbers[1]);

        for (int i = n2; i > 0; i--)
        {
            if (n1 % 10 == 0)
            {
                n1 = n1 / 10;
            }
            else
                n1--;
        }
        Console.WriteLine(n1);
    }
}