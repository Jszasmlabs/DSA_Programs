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

            Console.WriteLine("Popped Element: " + S.Pop());
            Console.WriteLine("Popped Element: " + S.Pop());
            Console.WriteLine("Popped Element: " + S.Pop());
            Console.WriteLine("Popped Element: " + S.Pop());

        }
    }
}