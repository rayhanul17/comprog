using System;

class A236
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string name2 = string.Empty;
        int count = 0;

        foreach (char c in name)
        {
            if (!name2.Contains(c))
            {
                name2 += c;
                count++;
            }
        }

        Console.WriteLine((count % 2 == 0) ? "CHAT WITH HER!" : "IGNORE HIM!");
    }
}
