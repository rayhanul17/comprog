using System;
public class A734
{
    public static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        int count1 = 0;
        int count2 = 0;

        foreach (char c in str)
        {
            if (c == 'A')
                count1++;
            else
                count2++;
        }
        
        Console.WriteLine(count1>count2?"Anton":count1<count2?"Danik": "Friendship");
    }
    
}