public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int buy = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            buy = Math.Min(buy, prices[i]);
            profit = Math.Max(profit, prices[i] - buy);
        }
        return profit;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.MaxProfit(new int[] { 2,4,1,5 });
        Console.WriteLine(ans);
    }
}