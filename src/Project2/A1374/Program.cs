using System;
class A1374
{
    public static void Main(string[] args)
    {
        int time = int.Parse(Console.ReadLine());

        for(int i = 0; i < time; i++)
        {
            string numString = Console.ReadLine();
            string[] num = numString.Split(' ');
            int x = int.Parse(num[0]);
            int y = int.Parse(num[1]);      
            int n = int.Parse(num[2]);

            int ans = n - n % x + y;
            if (ans <= n)
                Console.WriteLine(ans);
            else
                Console.WriteLine(n - n % x - (x-y));
        }
        
    }
}
