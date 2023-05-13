public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;

        int a = 1, b = 2, temp;
        for (int i = 2; i < n; i++)
        {
            temp = a; a = b;
            b = temp + b;
        }

        return b;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.ClimbStairs(3);
        Console.WriteLine(ans);
    }
}