using System;

class Program
{
    static void Main()
    {
        string[] words = { "shy", "shock", "shreder" };
        string prefix = "";
        int i = 0;
        while (true)
        {
            char a = words[0][i];
            foreach (var word in words)
            {
                if (i >= word.Length || word[i] != a)
                {
                    goto END;
                }
            }
            prefix += a;
            i++;
        }

        END: Console.WriteLine($"The longest prefix is: {prefix}");
    }
}
