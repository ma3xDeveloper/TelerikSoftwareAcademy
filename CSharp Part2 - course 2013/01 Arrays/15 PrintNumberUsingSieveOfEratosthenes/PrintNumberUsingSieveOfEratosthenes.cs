using System;
using System.Collections.Generic;
using System.Linq;

class PrintNumberUsingSieveOfEratosthenes
{
    static List<int> SieveLINQ(int upTo)
    {
        int index = 1;
        List<int> result = Enumerable.Range(2, upTo - 2).ToList();

        while (index <= Math.Sqrt(upTo))
        {
            index = result.First(i => i > index);
            result.RemoveAll(i => i != index && i % index == 0);
        }
        return result;
    }
    static void Sieve(int upTo)
    {
        bool[] notPrime = new bool[upTo];
        notPrime[0] = notPrime[1] = true;
        for (int i = 2; i < Math.Sqrt(notPrime.Length); i++)
        {
            if (!notPrime[i])
            {
                for (int j = i * 2; j < notPrime.Length; j += i)
                {
                    notPrime[j] = true;
                }
            }
        }
        //Print(notPrime);
    }
    static void Print(bool[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == false)
            {
                Console.Write(i + " ");
            }
        }
    }
    static void Main()
    {
        DateTime first = DateTime.Now;
        Sieve(10000000);
        TimeSpan normalSieveTime = DateTime.Now - first;
        DateTime second = DateTime.Now;
        List<int> linqResult = SieveLINQ(10000000);
        TimeSpan linqSieveTime = DateTime.Now - second;

        Console.WriteLine("Sieve with LINQ: {0}", linqSieveTime);
        Console.WriteLine("Sieve with bool: {0}", normalSieveTime);
    }
}

