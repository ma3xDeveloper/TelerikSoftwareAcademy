using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

namespace _02_RectangMatrixFindSquareMaxSum
{
    class RectangMatrixFindSquareMaxSum
    {

        static void Main()
        {
            const int n = 4; 
            const int m = 5; 

            int[,] matrix = new int[n, m] { { 5, 1, 4, 5, 9 },
                                        { 1, 3, 6, 5, 4 },
                                        { 7, 4, 8, 7, 45 },
                                        { 450, 1, 13, 1, 4}
                                      };
            Console.WriteLine("Our matrix looks like:");
            Console.WriteLine();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int maxSum = Int32.MinValue;
            int bestSeqIndexRow = -1;
            int bestSeqIndexCol = -1;
            if (n < 3 || m < 3)
            {
                Console.WriteLine("The values of N and M should be bigger or equal to 3");
            }
            else
            {
                for (int row = 0; row < n - 2; row++) 
                {
                    for (int col = 0; col < m - 2; col++) 
                    {
                        int tempSum = Int32.MinValue;
                        tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (tempSum > maxSum)
                        {
                            maxSum = tempSum;
                            bestSeqIndexCol = col;
                            bestSeqIndexRow = row;
                        }
                    }
                }
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("The best sum is : {0}", maxSum);
                Console.WriteLine();
                Console.WriteLine("The square 3x3 with best sums is:");

                for (int rows = 0; rows < 3; rows++)
                {
                    for (int cols = 0; cols < 3; cols++)
                    {
                        Console.Write("{0,3} ", matrix[bestSeqIndexRow + rows, bestSeqIndexCol + cols]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}