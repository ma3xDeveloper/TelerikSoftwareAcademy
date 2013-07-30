using System;

class TwoNumbersNandKGenAlVariationsKFromSet
{
    static int N;
    static int K;
    static int[] result;
    static void Main()
    {
        Console.WriteLine("This program reads two numbers N and K and generates all the variations of K elements from the set [1..N].\nPlease enter N and K");
        N = int.Parse(Console.ReadLine());
        K = int.Parse(Console.ReadLine());
        result = new int[K];
        Solve(0);
    }

    private static void Solve(int position)
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

        for (int i = 1; i <= N; i++)
        {
            result[position] = i;
            Solve(position + 1);
        }
    }
}