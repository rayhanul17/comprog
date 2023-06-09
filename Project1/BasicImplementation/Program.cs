public class MyLinkedList
{
    int val;
    MyLinkedList next;

    public MyLinkedList(int val = 0, MyLinkedList next = null)
    {
        this.val = val;
        this.next = next;
    }

    public int Get(int index)
    {
        int i = 0;
        while(i < index && next!=null && next.next!=null)
        {
            if(i+1 == index)
                return i;
            next = next.next;
            i++;
        }
        return -1;
    }

    public void AddAtHead(int val)
    {

    }

    public void AddAtTail(int val)
    {

    }

    public void AddAtIndex(int index, int val)
    {

    }

    public void DeleteAtIndex(int index)
    {

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int index = 0, val = 0;
        
        MyLinkedList obj = new MyLinkedList();
        int param_1 = obj.Get(index);
        obj.AddAtHead(val);
        obj.AddAtTail(val);
        obj.AddAtIndex(index, val);
        obj.DeleteAtIndex(index);

    }
}