public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int count = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                max = count > max ? count : max;
            }
            else
                count = 0;
        }
        return max;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
        Console.WriteLine(ans);
    }
}