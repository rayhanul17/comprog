public class Solution
{
    public int NumberOfSteps(int num)
    {
        if (num == 0) return 0;
        if (num % 2 == 0) return 1 + NumberOfSteps(num / 2);
        else return 1 + NumberOfSteps(num - 1);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.NumberOfSteps(123);
        Console.WriteLine(ans);
    }
}
