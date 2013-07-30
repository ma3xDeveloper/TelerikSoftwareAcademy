using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MaxSumInArray
{
    class MaxSumInArray
    {
        static void Main(string[] args)
        {
            //Write a program that finds the sequence of maximal sum in given array. Can you do it with only one loop (with single scan through the elements of the array)?



        int[] myArray = { 15, -85, 5, -8, 37, 4, 1 };   
        int currentSum = 0;
        int bestSum = int.MinValue;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum = currentSum + myArray[i];
            bestSequenceBuild.AppendFormat("{0}, ", myArray[i]);
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequnce = bestSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }
        Console.WriteLine("The best sequence is: \" {0} \" ", bestSequnce);
        Console.WriteLine("The best sum is: {0} ", bestSum);

        }
    }
}
