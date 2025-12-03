using System;

public class BracketsAlt
{
    public static bool IsValid(string s)
    {
        if (s == null) throw new ArgumentNullException(nameof(s));

        char[] buffer = new char[s.Length];
        int top = -1;

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                buffer[++top] = c;
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (top < 0) return false;

                char open = buffer[top--];

                bool matches =
                    (c == ')' && open == '(') ||
                    (c == '}' && open == '{') ||
                    (c == ']' && open == '[');

                if (!matches) return false;
            }
            else
            {
                return false;
            }
        } // <-- closes foreach

        return top == -1; // <-- after the loop
    }

    public static void Main()
    {
        string[] tests = { "()", "([])", "([)]", "{[()()]}", "(((", "({[()()]})" };

        foreach (var t in tests)
            Console.WriteLine($"{t} -> {IsValid(t)}");
    }
}
