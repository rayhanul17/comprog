using System;
class A703
{
    public static void Main(string[] args)
    {
        int line = int.Parse(Console.ReadLine());
        int chris = 0;
        int mishka = 0;
        for(int i = 0; i < line; i++)
        {
            string moves = Console.ReadLine();

            string[] move = moves.Split(' ');

            if (int.Parse(move[0]) < int.Parse(move[1]))
                chris++;
            else if (int.Parse(move[0]) > int.Parse(move[1]))
                mishka++;

        }
        Console.WriteLine((chris > mishka)? "Chris" : (mishka > chris)? "Mishka" : "Friendship is magic!^^");
    }
}
