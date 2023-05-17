public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{    
    public ListNode SwapPairs(ListNode head)
    {
        ListNode pointer = head;
        while(pointer != null && pointer.next != null)
        {
            (pointer.val, pointer.next.val) = (pointer.next.val, pointer.val);
            pointer = pointer.next.next;
        }
        return head;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.SwapPairs(new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 3, next = new ListNode { val = 4 } } } });
        Console.WriteLine(ans);
    }
}