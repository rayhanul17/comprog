public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> list = new List<string>();
        for(int i = 1; i <= n; i++)
        {
            string str = "";
            if (i % 3 == 0) str+="Fizz";
            if (i % 5 == 0) str+="Buzz";
            if (string.IsNullOrEmpty(str)) str += i;
            list.Add(str);
        }
        return list;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.FizzBuzz(15);
        ans.ToList().ForEach(x => Console.WriteLine(x));
    }
}
