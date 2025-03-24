using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("write down any number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine(Chek(num1));
        Console.WriteLine("write down any number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Chek(num2));
    }
    static bool Chek(int n)
    {
        {
            for (int i = 1; i <= n; i *= 2)
            {
                if (i == n) return true;
            }
            return false;
        }
    }
}