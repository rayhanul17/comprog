using System;
class A1154
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int gn = 0;
        int index = 0;
        int[] number = new int[numbers.Length];

        for(int i = 0; i < numbers.Length; i++)
            number[i] = int.Parse(numbers[i]);

        for(int i=0; i < number.Length; i++)
        {
            if (number[i] > gn)
            {
                gn = number[i];
                index = i;
            }
                
        }
       

        for (int i = 0; i < number.Length; i++)
        {
            if (i != index)
            {
                Console.Write("{0} ", gn - number[i]);
            }

        }
    }
}
