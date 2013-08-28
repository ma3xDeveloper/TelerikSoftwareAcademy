using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
05 Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
The output should be a single number in a separate text file.

ОБЯСНЕНИЕ: Подобна задача имаше в домашното за масиви, може да се използва кода от там.
*/

namespace _05_MaxSumOfMatrixFile
{
    class MaxSumOfMatrixFile
    {
        static int[,] ReadMatrix()
        {
            using (StreamReader read = new StreamReader("matrix.txt"))
            {
                int n = int.Parse(read.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] numbers = read.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++)
                        matrix[i, j] = int.Parse(numbers[j]);
                }

                return matrix;
            }
        }

        static int GetMax(int[,] matrix)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    maxSum = Math.Max(maxSum, matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);

            return maxSum;
        }

        static void WriteResult(int maxSum)
        {
            using (StreamWriter output = new StreamWriter("result.txt"))
                output.WriteLine(maxSum);
        }

        static void Main()
        {
            WriteResult(GetMax(ReadMatrix()));
        }
    }
}