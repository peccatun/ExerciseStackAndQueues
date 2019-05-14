using System;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int pushNums = int.Parse(input[0]);
            int pullNums = int.Parse(input[1]);
            int searchNum = int.Parse(input[2]);
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < pushNums; i++)
            {
                stack.Push(int.Parse(numbers[i]));
            }
            if (pullNums <= stack.Count)
            {
                for (int i = 0; i < pullNums; i++)
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(searchNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNum = int.MaxValue;
                int count = stack.Count;
                for (int i = 0; i < count; i++)
                {

                    if (minNum > stack.Peek())
                    {
                        minNum = stack.Pop();
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }
}
