int testCase = int.Parse(Console.ReadLine());
char[][] matrix = new char[8][];

for (int t = 0; t < testCase; t++)
{
    Console.ReadLine();
    for (int i = 0; i < 8; i++)
    {
        matrix[i] = Console.ReadLine().ToCharArray();
    }
    int r = 0;
    int c = 0;
    for (int i = 1; i < 7; i++)
    {
        for (int j = 1; j < 7; j++)
        {
            if (matrix[i][j] == '#' && matrix[i - 1][j - 1] == '#' && matrix[i + 1][j - 1] == '#')
            {
                r = i;
                c = j;
                break;
            }
        }
    }
    Console.WriteLine($"{r+1} {c+1}");
}
