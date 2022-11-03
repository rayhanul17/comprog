using System;
class A58
{
    public static void Main(string[] args)
    {
        bool condition = true;
        string[] charset = new string[] { "h", "e", "l", "l", "o" };

        string input = Console.ReadLine();

        int i = 0;
        int loc = 0;

        while (condition)
        {
            if (!input.Contains(charset[i]))
                condition = false;
            else if (i == 4)
                condition = false;
            if (input.Contains(charset[i]))
            {
                loc = input.IndexOf(charset[i]);
                input = input.Substring(loc + 1);
                i++;
            }
        }

        if (i == 5)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}