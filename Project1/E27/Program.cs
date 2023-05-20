public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int c = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != val)
                nums[c++] = nums[i];
        return c;
        var a = nums.Where( x => x != val).ToArray();
        nums = a;
        return nums.Length;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.RemoveElement(new int[] { 3, 2, 2, 3 }, 2);
        Console.WriteLine(ans);
    }
}