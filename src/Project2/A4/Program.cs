using System;
public class A4
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        if (num < 4)
        {
            Console.WriteLine("No");
        }
        else
        {
            num = num - 2;
            num %= 2;
            if(num == 0)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
        
    }
}