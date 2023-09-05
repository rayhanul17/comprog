public class Solution
{
    public int StrStr(string haystack, string needle)
    {               
        return haystack.IndexOf(needle);      
       
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