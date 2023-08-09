public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        strs = strs.OrderBy(x => x.Length).ToArray();
        string ss = "";
        for(int i = 0; i < strs[0].Length; i++)
        {
            for(int j = 1; j < strs.Length; j++) 
            {
                if (!strs[0][i].Equals(strs[j][i]))
                    return ss;
            }
            ss += strs[0][i];
        }
        return ss;
    }
}  

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.LongestCommonPrefix(new string[] { "dog", "racecar", "car" });
        Console.WriteLine(ans);
    }
}