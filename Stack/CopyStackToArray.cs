using System;
using System.Collections;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5];
            Stack S = new Stack(5);

            S.Push(10);
            S.Push(20);
            S.Push(30);
            S.Push(40);

            S.CopyTo(arr, 1);

            Console.WriteLine("Items are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\tItem[" + (i + 1) + "]: "+arr[i]);
            }
        }
    }
}