using System.Collections;

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
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) { slow = slow.next; fast = fast.next.next; }
        return slow;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var ans = s.MiddleNode(new ListNode(1,new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
        if(ans != null)
        {
            while(ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
