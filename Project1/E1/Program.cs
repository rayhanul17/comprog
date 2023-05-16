public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for(int i =0; i < nums.Length-1; i++)
        {
            for(int j=i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] {i, j};
            }
        }
        return new int[0];
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.TwoSum(new int[] {2, 7, 11, 15}, 9);
        Console.WriteLine(ans);
    }
}