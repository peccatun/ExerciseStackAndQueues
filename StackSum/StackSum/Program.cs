using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNums = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(firstNums);
            string command = string.Empty;
            while ((command = Console.ReadLine()
                .ToLower()) != "end")
            {
                string[] commandNums = command
                    .Split(" ");
                if (commandNums[0] == "add")
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        stack.Push(int.Parse(commandNums[i]));
                    }
                }
                if (commandNums[0] == "remove")
                {
                    for (int i = 0; i < int.Parse(commandNums[1]); i++)
                    {
                        if (stack.Count < int.Parse(commandNums[1]))
                        {
                            break;
                        }
                        stack.Pop();
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
