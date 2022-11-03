using System;

public class A263
{
    public static void Main(string[] args)
    {
        int[] position = new int[2];
        string[] lines = new string[5];
        string[,] matrix = new string[5, 5];


        for (int i = 0; i < 5; i++)
            lines[i] = Console.ReadLine();

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                matrix[i, j] = lines[i].Split(' ')[j];

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                if (matrix[i, j] == "1")
                {
                    position[0] = i;
                    position[1] = j;
                    break;
                }       
        Console.WriteLine(Math.Abs(position[0] - 2) + Math.Abs(position[1] - 2));
    }
}




