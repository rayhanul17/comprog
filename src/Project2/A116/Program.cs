using System;

class A116
{
    public static void Main(string[] args)
    {
        int line = int.Parse(Console.ReadLine());
        //string[] out_in = new string[line];
        int[] _out = new int[line];
        int[] _in = new int[line];

        int passengers = 0;
        int capacity = 0;

        for (int i = 0; i < line; i++)
        {
            string str = Console.ReadLine();
            _out[i] = int.Parse(str.Split(' ')[0]);
            _in[i] = int.Parse(str.Split(' ')[1]);

        }
        for (int i = 0; i < line; i++)
        {
            passengers = passengers + _in[i] - _out[i];
            if (passengers > capacity)
                capacity = passengers;
        }

        Console.WriteLine(capacity);

    }
}
