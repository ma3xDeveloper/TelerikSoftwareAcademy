//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AppearanceOfNumberInArr
{
    public class AppearanceOfNumberInArr
    {
        public static int CountAppearances(int[] array, int searchedNumber)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedNumber)
                {
                    counter++;
                }
            }
            return counter;
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

            Console.WriteLine("Enter the number to check it's appearances in the array");
            int searchedNumber = int.Parse(Console.ReadLine());
          
            CountAppearances(array, searchedNumber);
            Console.WriteLine("The number {0} appears {1} times in the array", searchedNumber, CountAppearances(array, searchedNumber));

        }
    }
}

//ОБЯСНЕНИЕ: Методът, който трябва да създадем за тази задача трябва да провери колко пъти един елемент се съдържа в даден масив от числа.
//Декларираме си един CountAppearances метод, в чието условие body кодът е много прост - for цикъл, който обхожда цикъла
//и сравнява елемент по елемент, дали числото което търсим се съдържа в него. В променливата counter отброяваме броя на съвпаденията, ако такива има.