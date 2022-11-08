using System;
public class B999
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str1 = Console.ReadLine();
        string str2 = string.Empty;
        
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                str2 = rev(str1.Substring(0, i));
                str1 = str2 + str1.Substring(i);               

            }
        }

        Console.WriteLine(str1);

        string rev(string str)
        {
            string revString = string.Empty;
            foreach (char str2 in str)
                revString = str2 + revString;
            return revString;
        }
        
    }
}