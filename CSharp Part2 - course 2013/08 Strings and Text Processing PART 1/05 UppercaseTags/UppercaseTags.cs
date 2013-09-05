using System;
using System.Text.RegularExpressions;

/*
05 You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
Example:
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result:
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

ОБЯСНЕНИЕ: Задача, чиято цел е да ви сблъска с т.нар. "лакомо" (greedy) съвпадение и "мързеливо" (lazy) съвпадение. В случая машината на регулярните изрази по подразбиране 
се опитва да намери най-дългото възможно съвпадение в текста - т.е. първия отварящ и последния затварящ таг. Това се нарича лакомо съвпадение. Решението на проблема е да се използва т.нар. мързеливо съвпадение, 
при което се добавя символа "?" след всеки от метасимволите за коли-чество, ние принуждаваме машината на регулярните изрази да приеме първото възможно (съответно и най-кратко) съвпадение.
Използваме Regex.Replace за да  заменим малките букви от текста с големи. След това с ламбда израза (=>) взимаме съдържанието за всеки Match (m) и му правим буквите главни (ToUpper).

*/

namespace _05_UppercaseTags
{
    class UppercaseTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
