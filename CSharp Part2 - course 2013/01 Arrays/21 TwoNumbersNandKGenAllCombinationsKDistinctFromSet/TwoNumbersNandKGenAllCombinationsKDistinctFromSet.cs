using System;

class TwoNumbersNandKGenAllCombinationsKDistinctFromSet
{

    static int N;
    static int K;
    static int[] result;

    static void Main()
    {
        Console.WriteLine("This program reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].\nPlease enter N and K");
        N = int.Parse(Console.ReadLine());
        K = int.Parse(Console.ReadLine());
        result = new int[K];
        Solve(0, 0);
    }

    private static void Solve(int position, int currentIndex)
    {
        if (position == result.Length)
        {
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            return;
        }

        for (int i = currentIndex + 1; i <= N; i++)
        {
            result[position] = i;
            currentIndex++;
            Solve(position + 1, currentIndex);
        }

    }
}