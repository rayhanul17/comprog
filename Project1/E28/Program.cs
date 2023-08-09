public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Contains(needle))            
            return haystack.IndexOf(needle);        
        else
            return -1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.StrStr("asadbutsad", "sad");
        Console.WriteLine(ans);
    }
}