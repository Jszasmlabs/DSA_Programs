// C# program  to check whether the given element is present or not in the LinkedList
using System;
using System.Collections.Generic;
  
class LinkedListSearch {
    
    static public void Main()
    {
        LinkedList<String> my_list = new LinkedList<String>();
    
        my_list.AddLast("Zoya");
        my_list.AddLast("Shilpa");
        my_list.AddLast("Rohit");
        my_list.AddLast("Rohan");
        my_list.AddLast("Juhi");
  
        if (my_list.Contains("Shilpa") == true) 
        {
            Console.WriteLine("Element Found...!!");
        }
        else 
        {
            Console.WriteLine("Element Not found...!!");
        }
    }
}