using System;
using System.Collections;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main()
        {
            Stack S = new Stack(5);

            S.Push(10);
            S.Push(20);
            S.Push(30);
            S.Push(40);

            if (S.Contains(30))
                Console.WriteLine("Item found in stack");
            else
                Console.WriteLine("Item did not find in stack");
            
        }
    }
}