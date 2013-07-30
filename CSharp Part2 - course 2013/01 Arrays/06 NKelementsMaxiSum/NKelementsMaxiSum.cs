using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NKelementsMaxiSum
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array element {0}: ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        string bestSeq = "";
        int sum = 0;
        int bestSum = int.MinValue;
        int arrayLen = myArray.Length;
        for (int i = 0; i < arrayLen; i++)
        {
            string currentSeq = "";

            if (i + k > arrayLen)
            {
                break;
            }

            for (int j = i; j < i + k; j++)
            {
                sum = sum + myArray[j];
                currentSeq = currentSeq + ' ' + myArray[j];
            }

            if (sum > bestSum)
            {
                bestSeq = currentSeq;
                bestSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine(bestSeq);
        Console.WriteLine(bestSum);

    }
}

//ОБЯСНЕНИЕ: Решението е подобно като на задача 5. Особеното е че с if условие се прави проверка i + k > arrayLen, дали случайно не сме излезнали от рамките на масива.
//След това за всяка "заградена" съвкупност от i+k индекси до края на масива правим сравнеиня на самите суми и намираме, коя е най-голямата.