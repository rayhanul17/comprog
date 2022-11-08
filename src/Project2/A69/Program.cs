using System;

public class A69
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] nums = new int[n,3];
        int[] sum = new int[3];

        for(int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for(int j=0; j<3; j++)
            {
                nums[i,j] = int.Parse(line[j]);
            }

        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum[i] = sum[i] + nums[j, i];
            }
        }
        Console.WriteLine((sum[0] == 0 && sum[1] == 0 && sum[2] == 0)?"YES" : "NO");
    }
}
