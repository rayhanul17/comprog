using System;

class A41
{
    public static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        string str3 = string.Empty;
        foreach (char c in str2)
        {
            str3 = c + str3;
        }
        if (str1 == str3)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}