using System;
public class A25
{
    public static void Main(string[] args)
    {        
        int index = 1;
        int even_count = 0;
        int odd_count = 0;

        int n = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');

        int[] num = new int[n];

        for(int i = 0; i < n; i++)
        {
            num[i] = int.Parse(nums[i]);
        }
        
        for(int i = 0; i < n; i++)
        {
            
            if (num[i] % 2 == 0)
                even_count++;
            else
                odd_count++;

        }
        
        if(even_count == 1)
        {
            for(int i = 0; i < n;i++)
                if (num[i] % 2 == 0)
                {
                    index = index + i;
                    break;
                }
        }
        else
        {
            for(int i = 0;i < n;i++)
                if(num[i] % 2 != 0)
                {
                    index = index + i;
                    break;
                }
        }
        Console.WriteLine(index);
    }
}