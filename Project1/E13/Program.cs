public class Solution
{
    Dictionary<char, int> cv = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
    public int RomanToInt(string s)
    {
        if (s.Length == 1)
            return cv[s[0]];
        int v = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (cv[s[i]] >= cv[s[i + 1]])
                v += cv[s[i]];
            else
                v += cv[s[i + 1]] - cv[s[i++]];
        }
        if (cv[s[s.Length-2]] >= cv[s[s.Length - 1]])
            v += cv[s[s.Length-1]];
        return v;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.RomanToInt(Console.ReadLine());
        Console.WriteLine(ans);
    }
}