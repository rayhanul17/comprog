int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] candies = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(candies);
    if (n == 1)
        Console.WriteLine(candies[0] == 1 ? "YES" : "NO");
    else
        Console.WriteLine(candies[n - 1] - candies[n - 2] < 2 ? "YES" : "NO");
}