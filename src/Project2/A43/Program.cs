using System;
public class A43
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string s = string.Empty;
        string s1 = string.Empty;
        string s2 = string.Empty;

        int s1Count = 0;
        int s2Count = 0;

        for(int i = 0; i < n; i++)
        {
            s = Console.ReadLine();

            if (i == 0)
                s1 = s;

            else if (s1 != s )
                s2 = s;

            if(s == s1)
                s1Count++;

            else if(s == s2)
                s2Count++;
        }

        Console.WriteLine(s1Count>s2Count?s1:s2);
        }
}