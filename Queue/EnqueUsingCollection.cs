using System;
using System.Collections;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main()
        {
            Queue Q = new Queue(5);

            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(40);

            Console.WriteLine("Items are added or enqueued into Queue.");

        }
    }
}