using System;

class ArrayOfStringsUsingQuickSort
{
    static void QuickSortAlg(int[] arr, int left, int right)
    {
        int originalLeft = left;
        int originalRight = right;
        int pivot = arr[(left + right) / 2];

        while (left < right)
        {
            while (pivot > arr[left])
            {
                left++;
            }
            while (pivot < arr[right])
            {
                right--;
            }
            if (left <= right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }
        if (originalLeft < right)
        {
            QuickSortAlg(arr, originalLeft, right);
        }
        if (left < originalRight)
        {
            QuickSortAlg(arr, left, originalRight);
        }
    }
    static void Main()
    {

        //Write a program that sorts an array of strings using the quick sort algorithm

        int[] arr = { 2, 1, 9, 4, 6, 7, 3, 5, 8, 10 };
        QuickSortAlg(arr, 0, 9);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}

//ОПИСАНИЕ: Тази задача има за цел да ни запознае с Quick Sort алгоритъма - http://en.wikipedia.org/wiki/Quicksort