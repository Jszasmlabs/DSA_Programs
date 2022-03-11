using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
  
  LinkedList<string> linked = new LinkedList<string>();
  
  linked.AddLast("A");
  linked.AddLast("B");
  linked.AddLast("C");
 
  LinkedListNode<string> node = linked.Find("A");
  linked.AddAfter(node, "inserted"); // Insert a node before the second node (after the first node)
  
  foreach (var value in linked)
  {
      Console.WriteLine(value);
  }
    }
}