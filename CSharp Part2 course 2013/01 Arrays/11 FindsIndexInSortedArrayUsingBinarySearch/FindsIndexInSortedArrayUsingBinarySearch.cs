using System;

class FindsIndexInSortedArrayUsingBinarySearch
{
    static int BinSearch(int[] array, int key)
    {
        Array.Sort(array);
        int iMax = array.Length - 1;
        int iMin = 0;
        while (iMax >= iMin)
        {
            int iMidpoint = (iMin + iMax) / 2;
            if (array[iMidpoint] < key)
            {
                iMin = iMidpoint + 1;
            }
            else if (array[iMidpoint] > key)
            {
                iMax = iMidpoint - 1;
            }
            else
            {
                return iMidpoint;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] myArray = { 4, 7, 4, 6, 2, 7, 5, 12, 22, 13, };
        int key = 7;
        Console.WriteLine(BinSearch(myArray, key));
    }
}

//ОПИСАНИЕ: Задача имаща за цел да ни запознае с един от основните алгоритми в програмирането - Binary Search. Повече инфо за него тук - http://en.wikibooks.org/wiki/Algorithm_Implementation/Search/Binary_search