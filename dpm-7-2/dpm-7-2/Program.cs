using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("Write down any word: ");
        string word = Console.ReadLine();
        Console.WriteLine();
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == word.ToUpper()[i])
            {
                Console.Write(word.ToLower()[i]);
            }
            else if (word[i] == word.ToLower()[i])
            {
                Console.Write(word.ToUpper()[i]);
            }
        }
    }
}