public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        int count = 0;
        for(int i = s.Length - 1; i >= 0; i--) 
        {
            if (s[i] == ' ')
                break;
            count++;
        }
        return count;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.LengthOfLastWord("   fly me   to   the moon  ");
        Console.WriteLine(ans);
    }
}
