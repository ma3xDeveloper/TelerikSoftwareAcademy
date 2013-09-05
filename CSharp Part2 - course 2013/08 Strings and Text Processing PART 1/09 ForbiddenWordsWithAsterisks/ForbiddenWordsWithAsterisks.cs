using System;
using System.Text.RegularExpressions;

/*
09 We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.

Example: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Words: "PHP, CLR, Microsoft"

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

ОБЯСНЕНИЕ: С Regex.Replace търсим и заместваме със звезди символите на думите PHP или ("|") или CLR или Microsoft.

*/

namespace _09_ForbiddenWordsWithAsterisks
{
    class ForbiddenWordsWithAsterisks
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string forbidWords = @"(\b(PHP|CLR|Microsoft)\b)";

            Console.WriteLine(Regex.Replace(text, forbidWords, m => new String('*', m.Length)));
        }
    }
}
