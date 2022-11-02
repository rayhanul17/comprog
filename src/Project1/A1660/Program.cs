int test = int.Parse(Console.ReadLine());
while (test-- > 0)
{
    int[] coins = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine(coins[0] == 0 ? 1 : coins[0] + coins[1] * 2 + 1);   
}
