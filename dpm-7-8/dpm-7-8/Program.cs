using System;
using System.Text;
class Programm
{
    static void Main()
    {
        Console.WriteLine("write down some numbers: ");
        string N = Console.ReadLine();
        Console.WriteLine(Func(N));
    }
    static string Func( string n)
    {
        StringBuilder result = new StringBuilder();

        foreach (char i in n)
        {
            int count = int.Parse(i.ToString());
            result.Append(i, count);
        }

        return result.ToString();
    }
}
