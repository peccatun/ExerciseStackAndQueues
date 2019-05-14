using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] expression = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(expression.Reverse());

            while(stack.Count > 1)
            {
                int operand1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operand2 = int.Parse(stack.Pop());
                switch (opr)
                {
                    case "+":
                        int sum = operand1 + operand2;
                        stack.Push(sum.ToString());
                        break;
                    case "-":
                        int result = operand1 - operand2;
                        stack.Push(result.ToString());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(stack.Peek());


        }
    }
}
