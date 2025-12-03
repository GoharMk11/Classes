using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Ex1
    {
        public static bool IsValid(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                    continue;
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Peek();

                    bool matches =
                        (c == ')' && top == '(') ||
                        (c == '}' && top == '{') ||
                        (c == ']' && top == '[');

                    if (!matches) return false;

                    stack.Pop();
                    continue;
                }

                return false; 
            }

            return stack.Count == 0;
        }

        public static void Main()
        {
            string[] tests = { "()", "([])", "([)]", "{[()()]}", "(((", "({[()()]})" };

            foreach (var t in tests)
                Console.WriteLine($"{t} -> {IsValid(t)}");
        }
    }
}
