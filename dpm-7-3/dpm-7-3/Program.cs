using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("write down number of steps");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(Fibonachi(N));
    }
    static int Fibonachi(int n)
    {
        if (n <= 1) return 1;
        int a = 1;//если уже на вершине
        int b = 1;//если один шаг до вершины
        for (int i = 2; i <= n; i++)
            {
            int temp = a + b;
            a = b;
            b = temp;
            }
        return b;
    }
}