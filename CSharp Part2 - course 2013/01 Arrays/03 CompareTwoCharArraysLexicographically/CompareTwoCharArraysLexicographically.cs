using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareTwoCharArraysLexicographically
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).
        
        char[] firstArray = { 'a', 'l', 'o', };
        char[] secondArray = { 'a', 'l', 'o', 'u', };
        
        bool areLexiEqual = true;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areLexiEqual = false;
                }
            }
            Console.WriteLine(areLexiEqual);
        }
        else
        {
            areLexiEqual = false;
            Console.WriteLine(areLexiEqual);
        }

    }
}

//ОБЯСНЕНИЕ: решението е почти същото като на задача 2 от Масиви. 
//Разликата е че зададох char-овете предварително в самия код, защото не се сетих как може да се направи, така че потребителя сам самичък да си ги въведене...