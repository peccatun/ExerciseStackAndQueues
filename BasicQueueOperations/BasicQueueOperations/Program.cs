using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int addNums = operands[0];
            int removeNums = operands[1];
            int searchNum = operands[2];
            int[] addNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbers = new Queue<int>(addNumbers);
            if (numbers.Count >= removeNums)
            {
                for (int i = 0; i < removeNums; i++)
                {
                    numbers.Dequeue();
                }
            }
            if (numbers.Count==0)
            {
                Console.WriteLine(0);
            }
            else if(numbers.Contains(searchNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNum = int.MaxValue;
                int count = numbers.Count;
                for (int i = 0; i < count; i++)
                {
                    int numberNow = numbers.Dequeue();
                    if (numberNow < minNum)
                    {
                        minNum = numberNow;
                    }
                }
                Console.WriteLine(minNum);
            }

        }
    }
}
