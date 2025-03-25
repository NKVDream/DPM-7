using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("verification process");
        Console.WriteLine();
        Console.WriteLine("write down your credit card number: ");
        string A = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(maskify(A));
        Console.WriteLine("what is your pet's name?");
        string B = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(maskify(B));
    }
    static string maskify(string a)
    {
        int length = a.Length;
        char replacementChar = '#';
        if (length <= 4)
        {
            return "";
        }
        string ForReplacement = a.Substring(0, length - 4);
        string last4 = a.Substring(length - 4);
        string replacedPart = new string(replacementChar, ForReplacement.Length);
        return replacedPart + last4;
    }
}
