using System;

/*
12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

ОБЯСНЕНИЕ: Тук отново целта е запознаване с ASCII талицата. С помощта на един for цикъл най-лесно може да се изпечатат всичките 255 символа в нея, 
като всеки елемент преди да го изпечатаме го кастваме към char и така се изпечатва и самия символ на конзолата.

 */

class AsciTable
{
    static void Main()
    {
        for (int i = 0; i < 255; i++)
        {
            char letter = (char)i;
            Console.WriteLine("number {0} {1}",i , letter);
        }
    }
}