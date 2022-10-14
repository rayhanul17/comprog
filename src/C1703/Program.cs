int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int len = int.Parse(Console.ReadLine());
    int[] finalPatter = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    string[] moves = new string[len];
    for (int i = 0; i < len; i++)
    {
        moves[i] = Console.ReadLine().Split(' ')[1];
    }
    for (int i = 0; i < len; i++)
    {
        foreach (char move in moves[i])
        {
            if (move == 'U' && finalPatter[i] != 0)
                finalPatter[i]--;
            else if (move == 'U' && finalPatter[i] == 0)
                finalPatter[i] = 9;
            else if (move == 'D' && finalPatter[i] != 9)
                finalPatter[i]++;
            else if (move == 'D' && finalPatter[i] == 9)
                finalPatter[i] = 0;
        }
    }
    Console.WriteLine(string.Join(" ", finalPatter));
}