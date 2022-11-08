using System;
public class A281
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string subString1 = input.Substring(1);
        char subString2 = Convert.ToChar(input.Substring(0, 1));

        if ((int)subString2 > 96 && (int)subString2 < 123)
        {
            subString2 = Convert.ToChar((int)subString2 - 32);
        }
        Console.WriteLine(subString2 + subString1);
    }
}
