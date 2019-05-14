using System;
using System.Collections.Generic;

namespace MatchingBrakets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    Console.Write('(');
                    for (int z = (stack.Pop() + 1); z < i; z++)
                    {
                        Console.Write($"{expression[z]}");
                    }
                    Console.Write(')');
                    Console.WriteLine();
                }
            }
        }
    }
}
