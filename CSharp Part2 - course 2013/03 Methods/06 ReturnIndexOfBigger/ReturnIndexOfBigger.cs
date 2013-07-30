//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ReturnIndexOfBigger
{
    class ReturnIndexOfBigger
    {

        public static int ReturnIndexOfFirstBiggest(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 2; i++)
            {
                if (IsBiggerThanNeighborsClass.CheckBiggerThanNeighbors(numbers, i) == true)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the Array indexes:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The first element in array that is bigger than its neighbors is: {0}", ReturnIndexOfFirstBiggest(array));
        }
    }
}

//ОБЯСНЕНИЕ: Тук задачате е почти аналогична на предходната с единсвената разлика, че трябва да намерим първия индекс в масива, чийто елемент е по-голям от обграждащите го. Ако няма такъв елемент, то програмата
//трябва да върне "-1". Естествено ще си използваме метода от предишната задача, като за по интересно реших да си го изнеса даже в отделен клас.