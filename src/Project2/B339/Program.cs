using System;

public class B339
{
    public static void Main(string[] args)
    {
        string[] houseTask = Console.ReadLine().Split(' ');
        string[] input = Console.ReadLine().Split(' ');

        int totalHouse = int.Parse(houseTask[0]);
        int length = int.Parse(houseTask[1]);
        int[] totalTask = new int[length];

        int index = 0;
        foreach (string c in input)
            totalTask[index++] = int.Parse(c);

        int start = 1;
        int end = totalTask[0];
        long count = 0;

        for (int i = 0; i < length; i++)
        {

            if (end < start)
            {
                count = count + (totalHouse - start) + end;
            }
            else if (end > start)
                count = count + (end - start);

            if (i != totalTask.Length - 1)
            {
                start = end;
                end = totalTask[i + 1];
            }
        }

        Console.WriteLine(count);
    }
}