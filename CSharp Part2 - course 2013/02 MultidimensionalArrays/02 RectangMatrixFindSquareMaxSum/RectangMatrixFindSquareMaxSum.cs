using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

ОБЯСНЕНИЕ: Подробно обяснение как се решава този тип задача, можете да намерите в учебника "Въведение в програмирането със C#" (стр. 258). 
За тва условие тук, единствената промяна която правим е, добавянето на още една колона и клетка към патерна за подматрицата 3x3, за която търсим най-голямата сума. 
*/
namespace _02_RectangMatrixFindSquareMaxSum
{
    class RectangMatrixFindSquareMaxSum
    {

        static void Main()
        {
            const int n = 4;
            const int m = 6;

            int[,] matrix = new int[n, m] { { 0, 2, 4, 0, 9, 5 },
                                        { 7, 1, 3, 3, 2, 1 },
                                        { 1, 3, 9, 8, 5, 6 },
                                        { 4, 6, 7, 9, 1, 0}
                                      };
            Console.WriteLine("The matrix:");
            Console.WriteLine();

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }

                }
            }

            Console.WriteLine("Thw maximal sum is: {0}", bestSum);

            Console.WriteLine();
            Console.WriteLine("The square 3x3 with best sums is:");

            for (int rows = 0; rows < 3; rows++)
            {
                for (int cols = 0; cols < 3; cols++)
                {
                    Console.Write("{0,3} ", matrix[bestRow + rows, bestCol + cols]);
                }
                Console.WriteLine();
            }
        }
    }
}