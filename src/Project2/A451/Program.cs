using System;

class A451
{
    public static void Main(string[] args)
    {
        string rc = Console.ReadLine();
        string[] vs = rc.Split(' ');
        int x = int.Parse(vs[0]);
        int y = int.Parse(vs[1]);
        
        if( x > y)
            x = y;

        if (x % 2 == 0)
            Console.WriteLine("Malvika");
        else
            Console.WriteLine("Akshat");


                  
    }
}