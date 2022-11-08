using System;
public class A271
{
    public static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        bool condition = true;
        while (condition)
        {
            year++;
            char[] digit = year.ToString().ToCharArray();
            if (digit[0] != digit[1] && digit[0] != digit[2] && digit[0] != digit[3] && digit[1] != digit[2] && digit[1] != digit[3] && digit[2] != digit[3])
            {
                condition = false;
                Console.WriteLine(year);
            }

        }
    }

}

