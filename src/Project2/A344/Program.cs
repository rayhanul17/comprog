using System;
public class A344
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        string now;
        string prev = string.Empty;

        for (int i = 0; i < n; i++) 
        { 
            now = Console.ReadLine();
            if(now != prev)
            {
                count++;
                prev = now;
            }
        }
        Console.WriteLine(count);

    }
}
