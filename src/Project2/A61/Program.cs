using System;
class A61
{
   public static void Main(string[] args)
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string result = string.Empty;

        for(int i = 0; i < num1.Length; i++)
        {
            if ((num1[i] == '1' && num2[i] == '0') || (num1[i] == '0' && num2[i] == '1'))
                result = result + '1';
            else
                result = result + '0';
        }
        Console.WriteLine(result);
    } 

}
