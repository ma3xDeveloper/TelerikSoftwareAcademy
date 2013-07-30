using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. 
        //Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, 
        //move it at the first position, find the smallest from the rest, move it at the second position, etc.


        int[] myArray = { 12, 5, 90, 35, 358 };
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < myArray.Length; p++)
            {
                if (myArray[p] < myArray[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = myArray[i];
                myArray[i] = myArray[elementMin];
                myArray[elementMin] = temp;
            }
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("{0}, ", myArray[i]);
        }
        Console.WriteLine();
    }
}

//ОБЯСНЕНИЕ: Основна задача за сортиране на масив, може би една от задачите за масиви (и в частност тяхното сортиране) с най-много обяснения в интернет.
//http://en.wikipedia.org/wiki/Selection_sort