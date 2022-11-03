using System;
class A158
{
    public static void Main(string[] args)
    {
        string[] sizeIndex = Console.ReadLine().Split(' ');
        string[] inputedLine = Console.ReadLine().Split(' ');
        int size = int.Parse(sizeIndex[0]);
        int index = int.Parse(sizeIndex[1]);
        int[] items = new int[size];

        int count = 0;
        int i = 0;

        foreach (string item in inputedLine)
            items[i++] = int.Parse(item);

        foreach (int item in items)
        {

            if (item >= items[index - 1] && item != 0)
                count++;
        }

        Console.WriteLine(count);

    }
}
