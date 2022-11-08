using System;
class A467{
    public static void Main(string[] args)
    {
        int line = int.Parse(Console.ReadLine());
        int count = 0;
        
        string[] room = new string[line];

        for(int i = 0; i < line; i++)
            room[i] = Console.ReadLine();

        for(int i=0; i < line; i++)
        {
            string[] capAvail = room[i].Split(' ');

            if (int.Parse(capAvail[1]) - int.Parse(capAvail[0]) >= 2)
                count++;

        }
        Console.WriteLine(count);
    }
}
