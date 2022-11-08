using System;

public class A231
{
    public static void Main(string[] args)
    {
        int line = int.Parse(Console.ReadLine());
        
        int solved = 0;
        for(int i = 0; i < line; i++)
        {
            string sol = Console.ReadLine();

            string[] found_sol = sol.Split(" ");
            int count = 0;

            for(int j=0; j<3; j++)
            {
                if(found_sol[j] == "1")
                    count++;

            }
            if(count >= 2)
                solved++;
        }

        Console.WriteLine(solved);
    }
}
