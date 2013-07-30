using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) as shown below: 


namespace _01_FillsAndPrintsMatrix
{
    class FillsAndPrintsMatrix
    {
        static int[,] fillMatrixA(int n)
        {
            int count = 1;
            int[,] matrix = new int[n, n];
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[cols, rows] = count++;
                }
            }
            return matrix;
        }
        static int[,] fillMatrixB(int n)
        {
            int[,] matrix = new int[n, n];
            int count = 1;
            for (int rows = 0; rows < n; rows++)
            {
                if (rows % 2 == 0)
                {
                    for (int cols = 0; cols < n; cols++)
                    {
                        matrix[cols, rows] = count++;
                    }
                }
                else
                {
                    for (int cols = n - 1; cols >= 0; cols--)
                    {
                        matrix[cols, rows] = count++;
                    }
                }
            }
            return matrix;
        }

        static int[,] fillMatrixC(int n)
        {
            int[,] matrix = new int[n, n];
            int rows = 0;
            int cols = 0;
            int value = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = value++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = value++;
                }
            }
            return matrix;
        }
        static int[,] fillMatrixD(int n)
        {
            int[,] result = new int[n, n];
            int numberToAdd = 1;
            int globalCounter = n;
            int tempValue = -n;
            int sum = -1;

            do
            {
                tempValue = -1 * tempValue / n;
                for (int i = 0; i < globalCounter; i++)
                {
                    sum += tempValue;
                    result[sum / n, sum % n] = numberToAdd;
                    numberToAdd++;
                }
                tempValue *= n;
                globalCounter--;
                for (int i = 0; i < globalCounter; i++)
                {
                    sum += tempValue;
                    result[sum / n, sum % n] = numberToAdd;
                    numberToAdd++;
                }
            } while (globalCounter > 0);

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int p = 0; p < matrix.GetLength(1); p++)
                {
                    Console.Write("{0, -4}", matrix[i, p]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the n number:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose which matrix to print? Enter 1, 2, 3 or 4: ");
            int matrixChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (matrixChoice == 1)
            {
                int[,] a = fillMatrixA(n);
                PrintMatrix(a);
            }

            if (matrixChoice == 2)
            {
                int[,] a = fillMatrixB(n);
                PrintMatrix(a);
            }

            if (matrixChoice == 3)
            {
                int[,] a = fillMatrixC(n);
                PrintMatrix(a);
            }

            if (matrixChoice == 4)
            {
                int[,] a = fillMatrixD(n);
                PrintMatrix(a);
            }
        }
    }
}

//ОбЯСНЕНИЕ: Разделям четирете поддточки на задачата с if условия, като от конзолата потребителя си избира, коя матрица да се принтира.
//Кодът за всяка една от тях е изнесена в отделен метод.
//- fillMatrixA: най-лесната матрица за печатане, като вместо [row, col] използваме [col, row].
//- fillMatrixB: при втората матрица отново редовете и колоните са разменени при инициализирането. Особеното тук е, че проверяваме дали текущата колона е четна. Ако да - цикълът ни е от 0 до дължината на масива. Ако е нечетна - от дължината до 0.
//- fillMatrixC: третата матрица я запълваме не по ред и колона, а по диагонали. Първо под главния диагонал и после допълваме над главния.
//- fillMatrixD: 