using System;
class A705
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        for(int i = 1; i <= num; i++)
        {
            if( i%2 == 0)
            {
                Console.Write("I love");
                if( i == num)
                    Console.Write(" it");
                else
                    Console.Write(" that ");
            }
            else
            {
                Console.Write("I hate");
                if(i == num)
                    Console.Write(" it");
                else
                    Console.Write(" that ");
            }
        }
    }
}
