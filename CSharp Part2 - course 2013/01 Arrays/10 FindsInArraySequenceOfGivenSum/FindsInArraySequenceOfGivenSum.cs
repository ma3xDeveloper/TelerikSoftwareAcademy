using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FindsInArraySequenceOfGivenSum
{
    class FindsInArraySequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present). 

            int i = 0, j = 0, k = 0, NumOfSums = 0, sum = 0, start = 0, end = 0;
            Console.WriteLine("Enter the length of the array N:");
            string Nstr = Console.ReadLine();
            int N = int.Parse(Nstr);
            Console.WriteLine("Enter the sum S:");
            string Sstr = Console.ReadLine();
            int S = int.Parse(Sstr);
            int[] Arr = new int[N];
            while (i < N)
            {
                Console.WriteLine("Please enter the {0} number of the array", i + 1);
                string Numstr = Console.ReadLine();
                Arr[i] = int.Parse(Numstr);
                i++;
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i + j < N)
                    {
                        sum = sum + Arr[i + j];
                        if (sum == S)
                        {
                            start = i;
                            end = i + j;
                            NumOfSums++;
                            Console.Write("\nS sum elements are: ");
                            for (k = start; k <= end; k++)
                            {
                                Console.Write("{0}; ", Arr[k]);
                            }
                        }
                    }
                }
                sum = 0;
            }
            Console.Write("\nS sum number is: {0}\n", NumOfSums);
        }
    }
}