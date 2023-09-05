public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        int ans = 0;
        string maxStr = s[0] + "";
        foreach (char c in s)
        {
            if (!maxStr.Contains(c))
                maxStr += c;
            else
            {
                ans = maxStr.Length > ans ? maxStr.Length : ans;
                maxStr = maxStr[maxStr.Length-1] + c.ToString();
            }
        }
        ans = maxStr.Length > ans ? maxStr.Length : ans;
        return ans;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.LengthOfLongestSubstring("au");
        Console.WriteLine(ans);
    }
}