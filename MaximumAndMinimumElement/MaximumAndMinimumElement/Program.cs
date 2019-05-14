using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] commandNum = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (commandNum[0] == 1)
                {
                    stack.Push(commandNum[1]);
                }
                if (commandNum[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                if (commandNum[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                if (commandNum[0] == 4)
                {
                    //minimum
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            int[] forPrint = stack.ToArray();
            Console.WriteLine(string.Join(", ", forPrint));
        }
    }
}
