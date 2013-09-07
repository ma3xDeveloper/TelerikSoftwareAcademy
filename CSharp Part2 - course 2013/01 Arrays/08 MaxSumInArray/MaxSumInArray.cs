using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MaxSumInArray
{
    class MaxSumInArray
    {
        static void Main()
        {
            //Write a program that finds the sequence of maximal sum in given array. Can you do it with only one loop (with single scan through the elements of the array)?
            //Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  ->  {2, -1, 6, 4}


            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int currentSum = array[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;
            int maxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                    tempStartIndex = i;
                }
                else
                {
                    currentSum += array[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }

            Console.WriteLine("The best sum is: {0} ", maxSum);

            Console.WriteLine("The best sequence is:");

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

/*
ОБЯСНЕНИЕ: За решението на тази задача трябва да се използва алгоритъма на Кадан - http://en.wikipedia.org/wiki/Kadane%27s_algorithm
Инициализираме си масив. Създаваме си 5-те основни променливи, които ще използваме в алгоритъма на Кадан. След това принтираме резултата на конзолата.
*/