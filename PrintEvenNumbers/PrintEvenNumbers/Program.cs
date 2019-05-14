using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbers = new Queue<int>(input);
            List<int> print = new List<int>();
            while (numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                if (number % 2 == 0)
                {
                    print.Add(number);
                }
            }
            Console.WriteLine(string.Join(", ",print));
           
        }
    }
}
