public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int count = 0;
        foreach (int x in nums)        
            if ((Math.Floor(Math.Log10(x)) + 1) % 2 == 0)
                count++;
        
        return count;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.FindNumbers(new int[] { 555, 901, 482, 1771 });
        Console.WriteLine(ans);
    }
}