using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantiti = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(orders);
            int biggestOrder = queue.Max();
            int order = 0;
            bool hasFailed = false;
            while (queue.Count > 0)
            {
                order = queue.Peek();
                quantiti -= order;
                if (quantiti >= 0)
                {
                    queue.Dequeue();
                }
                if (quantiti < 0)
                {
                    hasFailed = true;
                    break;
                }

            }
            Console.WriteLine(biggestOrder);
            if (hasFailed)
            {
                Console.WriteLine("Orders left: " + string.Join(' ', queue.ToArray()));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
