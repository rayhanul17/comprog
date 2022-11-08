using System;

public class A1436
{
    public static void Main(string[] args)
    {
        int tastcase = int.Parse(Console.ReadLine());

        for (int t = 0; t < tastcase; t++)
        {
            string[] ele_ans = Console.ReadLine().Split(' ');
            string[] nums = Console.ReadLine().Split(' ');

            int element = int.Parse(ele_ans[0]);
            int ans = int.Parse(ele_ans[1]);

            int[] num = new int[element];
            int count = 0;
            decimal sum = 0;

            foreach (string s in nums)
            {
                num[count] = int.Parse(s);
                count++;
            }

            Array.Sort(num);

            for (int i = 0; i < element; i++)
            {
                for (int j = i; j < element; j++)
                    sum = sum + num[j] / (decimal)(j + 1);
            }

            Console.WriteLine(Math.Round(sum) == ans ? "YES" : "NO");
        }
    }
}