int n = int.Parse(Console.ReadLine());
int[][] colorSet = new int[n][];
int count = 0;
for (int i = 0; i < n; i++)
    colorSet[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        if (colorSet[i][0] == colorSet[j][1])
            count++;
Console.WriteLine(count);