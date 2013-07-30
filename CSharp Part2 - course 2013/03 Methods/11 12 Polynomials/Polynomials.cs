//11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5 
//12. Extend the program to support also subtraction and multiplication of polynomials.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_Polynomials
{
    class Polynomials
    {
        static decimal[] DeclareArray(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                decimal num = decimal.Parse(Console.ReadLine());
                array[i] = num;
            }
            Array.Reverse(array);
            return array;
        }

        static decimal[] SumTwoArrays(decimal[] array1, decimal[] array2)
        {
            int biggerArray = array1.Length;
            int smallerArray = array2.Length;
            if (array2.Length > array1.Length)
            {
                biggerArray = array2.Length;
                smallerArray = array1.Length;
            }
            decimal[] sumArray = new decimal[biggerArray];

            for (int i = 0; i < biggerArray; i++)
            {
                if (i > smallerArray - 1)
                {
                    sumArray[i] = array1.Length > array2.Length ? array1[i] : array2[i];
                }
                else
                {
                    sumArray[i] = array1[i] + array2[i];
                }
            }

            return sumArray;
        }
        static decimal[] SubstractArrays(decimal[] array1, decimal[] array2)
        {

            int biggerLength = array1.Length;
            int smallerLength = array2.Length;

            if (array2.Length > array1.Length)
            {
                biggerLength = array2.Length;
                smallerLength = array1.Length;
            }

            decimal[] sumArray = new decimal[biggerLength];

            for (int i = 0; i < biggerLength; i++)
            {
                if (i > smallerLength - 1)
                {
                    sumArray[i] = array1.Length > array2.Length ? array1[i] : array2[i];
                }
                else
                {
                    sumArray[i] = array1[i] - array2[i];
                }
            }
            return sumArray;
        }
        static decimal[] MultiplyArrays(decimal[] array1, decimal[] array2)
        {
            decimal[] multiArrays = new decimal[array1.Length + array2.Length - 1];
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    multiArrays[i + j] += array1[i] * array2[j];
                }

            }
            return multiArrays;
        }
        static string ReturnPositiveSign(decimal[] array, int i)
        {
            if (array[i] > 0 && array.Length - 1 != i)
            {
                string signPlus = "+";
                return signPlus;
            }
            else
            {
                return string.Empty;
            }
        }
        static void PrintPolynom(decimal[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != 0)
                {
                    if (i != 0 && i != 1)
                    {
                        Console.Write(" {2}{0:F1}x^{1}", array[i], i, ReturnPositiveSign(array, i));
                    }
                    else if (i == 1)
                    {
                        Console.Write(" {1}{0:F1}x", array[i], ReturnPositiveSign(array, i));

                    }
                    else if (i == 0)
                    {
                        Console.Write(" {1}{0:F1}", array[i], ReturnPositiveSign(array, i));
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Enter degree of your 1 polynomial:");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
            decimal[] array1 = new decimal[degree + 1];
            DeclareArray(array1);

            Console.Write("Enter degree of your 2 polynomial:");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
            decimal[] array2 = new decimal[degree + 1];
            DeclareArray(array2);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Array 1:                 ");
            PrintPolynom(array1);
            Console.Write("Array 2:                 ");
            PrintPolynom(array2);
            Console.WriteLine();

            Console.Write("Sum:                     ");
            PrintPolynom(SumTwoArrays(array1, array2));


            Console.Write("Subtraction:             ");
            PrintPolynom(SubstractArrays(array1, array2));


            Console.Write("Multiplication:          ");
            PrintPolynom(MultiplyArrays(array1, array2));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}