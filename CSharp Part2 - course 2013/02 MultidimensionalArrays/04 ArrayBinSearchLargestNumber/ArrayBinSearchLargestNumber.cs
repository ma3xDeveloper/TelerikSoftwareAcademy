using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K. 

/*
ОБЯСНЕНИЕ: Изключително важна задача, чиято цел е да проучим как работи алгоритъмът BinarySearch - http://en.wikipedia.org/wiki/Binary_search_algorithm.
Готовият метод в C# е Array.BinarySearch. Характерно за него е, че ако търсеният елемент го няма в масива, то тогава BinarySearch връща отрицателно число (ако върнатата стойност е по-голяма или равна на нула, 
то търсения елемент съществува в масива). Ако методът върне отрицателно число бихме могли с помощта 
на побитовия оператор “~” да намерим индекса на първия елемент по-голям от търсения. Правим си три if проверки, за да можем да покрием всички
евентуални върнати стойности от BinarySearch-а.
*/

namespace _04_ArrayBinSearchLargestNumber
{
    class ArrayBinSearchLargestNumber
    {
        static void Main()
        {
            int[] array = { 8, 1, 0, 2, 3, 6, 6, 7 };
            Console.WriteLine("Please Enter K number: ");
            int K = int.Parse(Console.ReadLine());

            Array.Sort(array);

            int searchedNumber = Array.BinarySearch(array, K);
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            if (searchedNumber < -1)
            {
                Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);
            }
            else if (~searchedNumber == 0)
            {
                Console.WriteLine("No such number");
            }
            else
            {
                Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[searchedNumber]);
            }
        }
    }
}