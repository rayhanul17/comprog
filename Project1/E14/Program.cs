public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string ss = "";
        int i = 0;
        for(int j = 1; j < strs.Length; j++)
        {
            for(int k = 1; k < strs.Length; k++)
            {
                if(strs[0][i] != strs[k][j])
                    break;
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
        var ans = s.LongestCommonPrefix(new string[] {"dog", "racecar", "car"});
        Console.WriteLine(ans);
    }
}