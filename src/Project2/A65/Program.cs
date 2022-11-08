using System;
public class A71
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x;
        char str1, str2;
        string str;
        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            str = words[i];
            x = str.Length;
            if (x < 11)
                Console.WriteLine(str);            
            else
            {
                str1 = str[0];
                str2 = str[x - 1];
                str = Convert.ToString(str1) + Convert.ToString(x - 2) + Convert.ToString(str2);
                Console.WriteLine(str);
            }
        }
    }
}