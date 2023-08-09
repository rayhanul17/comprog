public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<int>();
        foreach (var ch in s)
        {
            if (ch is '(' or '[' or '{')
            {
                stack.Push(ch);
            }
            else
            {
                if (!stack.TryPop(out var pair)) return false;

                switch (ch)
                {
                    case ')':
                        if (pair != '(') return false;
                        break;
                    case ']':
                        if (pair != '[') return false;
                        break;
                    case '}':
                        if (pair != '{') return false;
                        break;
                }
            }
        }

        return stack.Count == 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        while (true)
        {
            var ans = s.IsValid(Console.ReadLine());
            Console.WriteLine(ans);
        }
    }
}