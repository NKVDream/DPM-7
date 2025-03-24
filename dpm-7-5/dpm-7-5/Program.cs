using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string ex = Console.ReadLine();
        bool tot = Check(ex);
        Console.WriteLine(tot);
    }

    static bool Check(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
            }
            else if (c == '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{') return false;
            }
            else if (c == ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[') return false;
            }
        }

        return stack.Count == 0;
    }
}
