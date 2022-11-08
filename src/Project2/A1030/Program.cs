using System;
public class A1030
{
    public static void Main(string[] args)
    {
        int persons = int.Parse(Console.ReadLine());
        string[] answers = Console.ReadLine().Split(' ');
        persons = 0;
        foreach (string answer in answers)
            if (answer == "1")
            {
                persons = 1;
                break;
            }
                

        Console.WriteLine(persons == 1? "HARD": "EASY");
    }

}
