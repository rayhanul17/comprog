int t = int.Parse(Console.ReadLine());
int[] result = new int[t];
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    result[i] = n % 2 == 0 ? n / 2 - 1 : n / 2;
}
Console.WriteLine(string.Join("\n", result));