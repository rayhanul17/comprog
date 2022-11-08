using System;
public class A50
{
    public static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int m = int.Parse(line[0]) * int.Parse(line[1]);
        Console.WriteLine(m/2);
    }
   
}
