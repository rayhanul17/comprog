int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int row = input[0], col = input[1];
    int minRow = int.MaxValue;
    int minCol = int.MaxValue;
    char[][] grid = new char[row][];

    for (int i = 0; i < row; i++)
        grid[i] = Console.ReadLine().ToCharArray();

    for(int j = 0; j < row; j++)
    {
        for (int k = 0; k < col; k++)
        {
            if (grid[j][k] == 'R')
            {
                minRow = Math.Min(minRow, j);
                minCol = Math.Min(minCol, k);
            }
        }
    }
    Console.WriteLine(grid[minRow][minCol] == 'R' ? "YES" : "NO");
}