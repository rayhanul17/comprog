using System;
public class A122
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string num = string.Empty;
        int count = 0;
        for(int i = 1; i < n; i++)
        {
            if(n%i == 0)
            {
                num = Convert.ToString(n/i);
                //Console.WriteLine(n/i);
                if (num.Contains("1") || num.Contains("2") || num.Contains("3") || num.Contains("5") || num.Contains("6") || num.Contains("8") || num.Contains("9") || num.Contains("0"))
                    continue;
                else
                    count = 1;
                    
            }                
        }
        Console.WriteLine(count==0?"NO":"YES");
    }
}
