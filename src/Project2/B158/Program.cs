using System;

public class B158
{
    public static void Main(string[] args)
    {
        int group = int.Parse(Console.ReadLine());
        int[] member = new int[group];
        string[] groups = Console.ReadLine().Split(' ');
        int i = 0;
        int one = 0;
        int two = 0;
        int three = 0;
        int four=0;
        int count = 0;
        int value = 0;

        foreach (string members in groups)
        {
            member[i] = int.Parse(groups[i].ToString());
            i++;
        }
        Array.Sort(member);
        foreach(int n in member)
        {
            if (n == 1)
                one++;
            else if(n == 2)
                two++;
            else if(n == 3)
                three++;
            else
                four++;
        }
        

        if (three > one)
        {
            count = three;
            one = 0;
        }
        else if (one > three)
        {
            count = three;
            one = one - three;
        }
        else
        {
            count = three;
            one = 0;
        }

        value = (two * 2 + one);

        two = value / 4;
        if (value % 4 > 0)
            two++;

        count = two + three + four;

        Console.WriteLine(count);
    }
}
