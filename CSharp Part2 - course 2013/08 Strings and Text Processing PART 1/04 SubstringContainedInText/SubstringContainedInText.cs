using System;
using System.Text.RegularExpressions;

/*
04 Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
Example: The target substring is "in". The text is as follows:
We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
The result is: 9

ОБЯСНЕНИЕ: Правим си две стринг променливи, съдържащи текста и подстринга (патерна) за проверка. Използваме Regex.Matches и неговите възможности за допълнителни настройки при работата с регулярни изрази, 
а именно RegexOptions, който съдържа различни константи, които се използват за указване на опции при търсенето с регулярни изрази. В случая използваме опцията IgnoreCase, която игнорира големи и малки букви. 
Свойството Count пък ни дава броя успешни съвпадения.
 */

namespace _04_SubstringContainedInText
{
    class SubstringContainedInText
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string pattern = "in";

            Console.WriteLine(Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count);
        }
    }
}
