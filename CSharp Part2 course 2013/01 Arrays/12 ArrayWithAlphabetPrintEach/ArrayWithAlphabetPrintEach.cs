using System;

class ArrayWithAlphabetPrintEach
{
    static int BinSearch(char[] arr, int left, int right, char value)
    {
        if (left > right)
        {
            return -1;
        }
        int middle = (left + right) / 2;
        if (arr[middle] == value)
        {
            return middle;
        }
        else if (arr[middle] < value)
        {
            return BinSearch(arr, middle + 1, right, value);
        }
        else
        {
            return BinSearch(arr, left, middle - 1, value);
        }
    }

    static void Main()
    {
        //initialize alphabet array
        char[] alphabet = new char[26];
        int first = (int)'A';
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(first + i);
        }

        Console.Write("Enter word (A-Z): ");
        string word = Console.ReadLine();
        foreach (char item in word)
        {
            Console.WriteLine(BinSearch(alphabet, 0, 25, item));
        }
    }
}