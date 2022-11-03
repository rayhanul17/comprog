using System;
public class B32
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        for(int i = 0; i < input.Length; i++)
        {
            
            if (input[i] == '-' && input[i + 1] == '.')
            {
                Console.Write(1);
                i++;
            }
            else if (input[i] == '-' && input[i + 1] == '-')
            {
                Console.Write(2);
                i++;
            }
            else
                Console.Write(0);
        }
    }
}