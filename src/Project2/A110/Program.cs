using System;
class A110
{
    public static void Main(string[] args)
    {
        string x = Console.ReadLine();
        int count = 0;
        foreach(char c in x)
        {
            if (c == '4' || c == '7')
            {
                count++;
            }
        }
        if(count == 4 || count == 7)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}