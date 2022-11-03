using System;

public class A59
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int i = 0;
        int j = 0;

        foreach (char c in word)
        {
            if (c >= 65 && c <= 90)
                i++;
            else
                j++;
        }

        if (i > j)
            Console.WriteLine(word.ToUpper());
        else
            Console.WriteLine(word.ToLower());
    }
}

