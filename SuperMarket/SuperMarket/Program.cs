using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    int remove = queue.Count;
                    for (int i = 0; i < remove; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine(queue.Count + " people remaining.");
        }
    }
}
