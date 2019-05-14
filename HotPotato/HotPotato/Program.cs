using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children =
                new Queue<string>(Console.ReadLine().Split());

            int n = int.Parse(Console.ReadLine());

            while (children.Count > 1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    string player = children.Dequeue();
                    children.Enqueue(player);
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
