using System;
class A1
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        decimal m = int.Parse(input[0]);
        decimal n = int.Parse(input[1]);
        decimal a = int.Parse(input[2]);
        
        Console.WriteLine(Math.Ceiling(Math.Ceiling(m/a) * Math.Ceiling(n/a)));
       
    }
}
