using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("how many people have been asked?");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random random = new Random();
        int[] Solutions = new int[N];
        int NegativeSol = 0;
        string AllSolutions = "";
        string FinalSolution = "";
        for (int i = 0; i < Solutions.Length; i++)
        {
            Solutions[i] = random.Next(0,2);
        }
        foreach (int i in Solutions)
        {
            AllSolutions+=$"{i}";
        }
        Console.WriteLine();
        foreach (int i in Solutions)
        {
            if(i == 0) continue;
            else if(i == 1) NegativeSol++;
        }
        if (NegativeSol > 0) FinalSolution+="HARD";
        else FinalSolution+="EASY";
        Console.WriteLine($"People = {N}");
        Console.WriteLine($"Solution = {AllSolutions}");
        Console.WriteLine($"Level of task: {FinalSolution}");
    }
}