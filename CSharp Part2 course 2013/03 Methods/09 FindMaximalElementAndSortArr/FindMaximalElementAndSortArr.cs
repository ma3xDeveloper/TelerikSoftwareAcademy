//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_FindMaximalElementAndSortArr
{
class FindMaximalElementAndSortArr
{
    static int MaxElementInArrPortion(int[] array, int givenIndex)
    {
        int biggestIndex = givenIndex;
        for (int i = givenIndex; i < array.Length; i++)
        {
            if (array[givenIndex] < array[i])
            {
                biggestIndex = i;
            }
        }
        return array[biggestIndex];
    }

    static void SortArrayAscending(int[] array) //метод, който сортира възходящо
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[elementMin];
                array[elementMin] = temp;
            }
       }
    }

    static void SortArrayDescending(int[] array)//метод, който сортира низходящо
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[elementMin];
                array[elementMin] = temp;
            }
        }
        Array.Reverse(array);
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
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

        Console.WriteLine("Enter the array index to start the check: ");
        int givenIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Maximal element in this array portion is: {0}", MaxElementInArrPortion(array, givenIndex));
        Console.WriteLine("Enter number 1 if you want to sort the array in Ascending order: ");
        Console.WriteLine("Enter number 2 if you want to sort the array in Descending order: ");
        int howToSort = int.Parse(Console.ReadLine());

        if (howToSort == 1)
        {
            SortArrayAscending(array);
            PrintArray(array);
        }

        if (howToSort == 2)
        {
            SortArrayDescending(array);
            PrintArray(array);
        }

        else if (howToSort != 1 && howToSort !=2)
        {
            Console.WriteLine("Error! Try Again!");
        }
    }
  }
}

//ОБЯСНЕНИЕ: Създаваме си един масив и му въвеждаме ръчно стойности. Посочваме и някакъв индекс от масива, от който индекс до края на масива ще се опитаме да намерим индекса с най-големия елемент. За да намерим най-големия елемент от някакъв отрязък от елементи в масива ще използваме метода MaxElementInArrPortion.
//Идеята му е, че приемаме първоначално, че индекса, който сме посочили за начало на отрязъка от елементи е именно индексът, на чиято позиция се съдържа най-големия елемент. С помощта на един лесен for Цикъл с if условие в MaxElementInArrPortion провеяваме това дали наистина е така, като сравняваме първоначално зададения индекс
//с всички останали елементи до края на масива. Ако намерим по голям елемент, просто if цикъла го заместваме в променливата biggestIndex и метода накрая ни връща на кой точно индекс се намира търсения от нас най-голям елемент в отрязъка.

//За сортирането на масива ще използваме SelectionSort алгоритъма, с който се запознахме в лекциите за многомерни масиви. Създаваме си класическия за целта SelectionSort медот с класическия за алгоритъма код, който можете да си копирате директно от предишните задачи.
//Ако потребителят въведе цифрата 1, ще се изпълни SortArrayAscending метода, който ще сортира масива възходящо и съответно, въведе 2 - ще се изпълни метода SortArrayDescending, който ще сортира низходящо. Между другото кодът при SortArrayDescending е същия с SortArrayAscending с разликата, че накрая reverse-ваме сортирания масив.