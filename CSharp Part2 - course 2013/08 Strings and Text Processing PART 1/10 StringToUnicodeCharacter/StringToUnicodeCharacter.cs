using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


/*
10 Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

Sample input: "Hi!".
Expected output: "\u0048\u0069\u0021".

ОБЯСНЕНИЕ: 

*/

namespace _10_StringToUnicodeCharacter
{
    class StringToUnicodeCharacter
    {
        static void Main()
        {
            List<int> list = new List<int>();
            string str = Console.ReadLine();
            foreach (var ch in str)
            {
                list.Add(ch + '\0');
            }
            foreach (var item in list)
            {
                string result = string.Format("\\u{0:X4}", item);
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}
