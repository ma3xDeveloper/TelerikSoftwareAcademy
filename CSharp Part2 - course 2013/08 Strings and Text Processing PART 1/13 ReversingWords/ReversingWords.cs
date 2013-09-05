using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


/*
13 Write a program that reverses the words in given sentence. Example:

C# is not C++, not PHP and not Delphi!
Delphi not and PHP, not C++ not is C#!

ОБЯСНЕНИЕ: Тук трябва да използваме Стек и Опашка.

*/

namespace _13_ReversingWords
{
    class ReversingWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter sentence");
            string sentence = Console.ReadLine();
            ReverseSentance(sentence);
        }
        static void ReverseSentance(string sentance)
        {
            string[] words = sentance.Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            Queue<string> punctuation = new Queue<string>();
            int i = 0;
            while (i < sentance.Length)
            {
                switch (sentance[i])
                {
                    case ' ':
                        punctuation.Enqueue(" ");
                        break;
                    case ',':
                        punctuation.Enqueue(", ");
                        i++;
                        break;
                    case '!':
                        punctuation.Enqueue("!");
                        break;
                    case '?':
                        punctuation.Enqueue("?");
                        break;
                    case '.':
                        punctuation.Enqueue(".");
                        break;
                    default:
                        break;
                }
                i++;
            }
            for (int j = words.Length - 1; j >= 0; j--)
            {
                Console.Write("{0}{1}", words[j], punctuation.Dequeue());
            }
            Console.WriteLine();
        }

    }
}

