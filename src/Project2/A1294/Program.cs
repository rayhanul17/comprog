using System;
class A1294
{
    public static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int j = 0; j < testCase; j++)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int gn = 0;
            int index = 0;
            int same = 0;
            int[] number = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
                number[i] = int.Parse(numbers[i]);

            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] > gn)
                {
                    gn = number[i];
                    index = i;
                }
            }
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (i != index)
                {
                    same = same + gn - number[i];
                }

            }
            int x = number[3] - same;
            Console.WriteLine((x < 0) ? "NO" : (x % 3 == 0) ? "YES" : "NO");

        }

    }
}