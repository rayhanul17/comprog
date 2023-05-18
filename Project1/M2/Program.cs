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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string s1= string.Empty, s2 = string.Empty;
        while(l1 != null || l2 != null) 
        {
            s1 = l1?.val+s1;
            s2 = l2?.val+s2;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        string n = (Convert.ToUInt32(s1) + Convert.ToUInt32(s2)).ToString();
        ListNode listNode = new ListNode();
        ListNode pointer = listNode;
        for(int i = n.Length-1; i > 0; i--)
        {
            pointer.val = (int)Convert.ToUInt32(n[i].ToString());
            pointer.next = new ListNode();
            pointer = pointer.next;
        }
        pointer.val = (int)Convert.ToUInt32(n[0].ToString());
        return listNode;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        ListNode l1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3 } } };
        ListNode l2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4 } } };
        s.AddTwoNumbers(l1, l2);
    }
}