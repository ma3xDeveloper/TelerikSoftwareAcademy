//Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IsBiggerThanNeighbors
{
    class IsBiggerThanNeighbors
    {
        private static void CheckByIndexNeighbors(int n, int[] array, int position)
        {
            if (position == 0 || position == array.Length-1)
            {
                Console.WriteLine("Number {0} on index {1} has only one neighbor!", array[position], position);
            }
            else if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("Number {0} on index {1} is bigger than its two neighbors", array[position], position);
            }
            else if (array[position] < array[position - 1] || array[position] < array[position + 1])
            {
                Console.WriteLine("Number {0} on index {1} is smaller than at least one of its two neighbors", array[position], position);
            }
            else
            {
                Console.WriteLine("Number {0} on index {1} is equal to its two neighbors", array[position], position);
            }
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

            Console.WriteLine("Enter the postion of element in the array to check");
            int position = int.Parse(Console.ReadLine());

            CheckByIndexNeighbors(n, array, position);
            }
    }
}

//ОБЯСНЕНИЕ: Целта на задачата е да по избран индекс от масива да сравним числото, което се намира на тази позиция дали е по-голямо от съседните числа, намиращи се на съседните индекси.
//Правим си един метод, в който изнасяме всички условия. Едни от най-важните са да проверим дали въведения индекс не е първия или последния индекс от масива, защото ако това е така, това означа, че
//просто няма елемнти, които до га обграждат и дефакто няма как да проверим условието на задачата.