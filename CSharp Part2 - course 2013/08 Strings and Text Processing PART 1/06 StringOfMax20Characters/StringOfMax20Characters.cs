using System;
using System.Text.RegularExpressions;

/*
06 Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
 the rest of the characters should be filled with '*'. Print the result string into the console.
 
ОБЯСНЕНИЕ: Лесна задача, за която не са необходими регулярни изрази. Достатъчно е да се използва метода PadRight, които в случая добавя липсващите символи, които остават до 20, със звездички.
*/

namespace _06_StringOfMax20Characters
{
    class StringOfMax20Characters
    {
        static void Main()
        {
            Console.WriteLine("Insert text here:");
            string str = Console.ReadLine();
            int maxStrLength = 20;

            if (str.Length <= maxStrLength)

            Console.WriteLine(str.PadRight(maxStrLength, '*'));
        }
    }
}
