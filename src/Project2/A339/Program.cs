using System;

class A339
{
    public static void Main(string[] args)
    {

        string input = Console.ReadLine();

        string[] stringArray = input.Split('+');
        int[] numberArray = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            numberArray[i] = int.Parse(stringArray[i]);
        }
        Array.Sort(numberArray);

        string data = string.Join("+", numberArray);
        Console.WriteLine(data.Trim('+'));
    }

}