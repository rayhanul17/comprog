using System;
public class A4
{
    public static void Main(string[] args)
    {
        int line = int.Parse(Console.ReadLine());
        string statement = string.Empty;
        int x = 0;

        for (int i = 0; i < line; i++)
        {
            statement = Console.ReadLine();

            if (statement.Contains("+"))
                x++;

            else
                x--;
        }
        Console.WriteLine(x);
    }
}