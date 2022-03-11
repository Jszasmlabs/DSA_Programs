/* C# program  to create a LinkedList */
using System;
using System.Collections.Generic;
  
class createLinkedList {
  
  
    static public void Main()
    {
  
    
        LinkedList<String> my_list = new LinkedList<String>();
  
        
        my_list.AddLast("first");
        my_list.AddLast("Second");
        my_list.AddLast("Third");
        my_list.AddLast("Fourth");
        my_list.AddLast("Fidth");
        my_list.AddLast("sisth");
  
        Console.WriteLine("The value in the Linked List:");
  
      
        foreach(string str in my_list)
        {
            Console.WriteLine(str);
        }
    }
}