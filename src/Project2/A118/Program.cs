using System;
class A118
{
    public static void Main(string[] args)
    {
        string str1, str2;

        str1 = Console.ReadLine().ToLower();

        foreach (char str in str1)
        {
            if (str != 'a' && str != 'e' && str != 'i' && str != 'o' && str != 'u' && str != 'y')
            {
                Console.Write("." + Convert.ToString(str));
            }

        }

    }
}



