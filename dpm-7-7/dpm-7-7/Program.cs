using System;
class Programm
{
    static void Main()
    {
        Random random = new Random();
        int[] gas = new int[5];
        for (int i = 0; i < gas.Length; i++)
        {
            gas[i] = random.Next(1,5);
        }
        int[] cost = new int[5];
        for (int i = 0;i < cost.Length; i++)
        {
            cost[i] = random.Next(1,5);
        }
        Console.WriteLine(Canister(gas, cost));
    }
    static int Canister(int[] gas, int[] cost)
    {
        int n = gas.Length;
        int totalTank = 0;
        int currentTank = 0;
        int startingStation = 0;

        for (int i = 0; i < n; i++)
        {
            totalTank += gas[i] - cost[i];
            currentTank += gas[i] - cost[i];

            if (currentTank < 0)
            {
                startingStation = i + 1;
                currentTank = 0;
            }
        }

        return totalTank >= 0 ? startingStation : -1;
    }
}