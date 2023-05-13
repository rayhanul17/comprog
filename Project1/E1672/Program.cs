class Solution
{
    public int maximumWealth(int[][] accounts)
    {
        int ans = 0;
        foreach(var e in accounts)
        {        
            ans = Math.Max(ans, e.Sum());
        }
        return ans;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.maximumWealth(new int[][] { new int[] { 1, 15 }, new int[] { 7, 3 }, new int[] { 3, 5 } });
        Console.WriteLine(ans);
    }
}
