public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        val = val;
        left = left;
        right = right;
    }
}

public class Solution
{
    public bool CheckTree(TreeNode root)
    {
        return root.val == root.left.val + root.right.val;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.CheckTree(new TreeNode { val = 10, left = new TreeNode { val = 6 }, right = new TreeNode { val = 5 } });
        Console.WriteLine(ans);
    }
}
