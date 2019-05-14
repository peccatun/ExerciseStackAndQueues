using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Stack<string> numbers = new Stack<string>(input.Reverse());
            while (numbers.Count > 1)
            {
                int operand1 = int.Parse(numbers.Pop());
                string operand = numbers.Pop();
                int operand2 = int.Parse(numbers.Pop());
                switch (operand)
                {
                    case "+":
                        int sum = operand1 + operand2;
                        numbers.Push(sum.ToString());
                        break;
                    case "-":
                        int result = operand1 - operand2;
                        numbers.Push(result.ToString());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(numbers.Pop());
        }
    }
}
