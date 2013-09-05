using System;
using System.Text.RegularExpressions;

/*
08 Write a program that extracts from a given text all sentences containing given word.

Example: The word is "in". The text is:
We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is:
We are living in a yellow submarine.
We will move out of it in 5 days.

Consider that the sentences are separated by "." and the words – by non-letter symbols.

ОБЯСНЕНИЕ: Трудното тук, както и при повечето задачи с регулярни изрази, е да се измайстори правилно шаблона, по който да се търси. В тази задача дадох име на групата
още в самия шаблон - ?<sentenceName>
*/

namespace _08_ExtractsFromTextSentences
{
    class ExtractsFromTextSentences
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";

            foreach (Match match in Regex.Matches(text, @"\s*(?<sentenceName>[^\.]*\b" + word + @"\b.*?\.)"))
                Console.WriteLine(match.Groups["sentenceName"]);
        }
    }
}
