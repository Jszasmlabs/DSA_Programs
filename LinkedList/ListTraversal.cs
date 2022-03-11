using System;

class ListNode
{
    private int item;
    private ListNode next;

    public ListNode(int value)
    {
        item = value;
        next = null;
    }
    public ListNode AddItem(int value)
    {
        ListNode node = new ListNode(value);
        if (this.next == null)
        {
            node.next = null;
            this.next = node;
        }
        else
        {
            ListNode temp = this.next;
            node.next = temp;
            this.next = node;
        }
        return node;
    }
        
    public void ListTraverse()
    {
        ListNode node = this;
            
        while (node != null)
        {
            Console.WriteLine("" + node.item);
            node = node.next;
        }
    }
}

class Demo
{
    static void Main(string[] args)
    {
        ListNode StartNode = new ListNode(201);

        ListNode n1;
        ListNode n2;
        ListNode n3;
        ListNode n4; 
           
        n1 = StartNode.AddItem(202);
        n2 = n1.AddItem(203);
        n3 = n2.AddItem(204);
        n4 = n3.AddItem(205);
            
        Console.WriteLine("Traversing of Linked list:");
        StartNode.ListTraverse();   
    }
}