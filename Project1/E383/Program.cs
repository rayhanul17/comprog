public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (var item in magazine)
        {
            if (map.ContainsKey(item)) map[item]++;
            else map[item] = 1;
        }

        foreach (var item in ransomNote)
        {
            if (map.ContainsKey(item) && map[item] > 0) map[item]--;
            else return false;
        }
        return true;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.CanConstruct("aa", "ab");
        Console.WriteLine(ans);
    }
}