using System;

/*
03 Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
 * 
 ОБЯСНЕНИЕ:

 */

namespace _03_BracketsCheck
{
    class BracketsCheck
    {
        static void Main()
        {
            Console.WriteLine("Please enter some expresion: ");
            string expresion = Console.ReadLine();
            int countOpenBracket = 0;
            int countClosedBracket = 0;
            foreach (var ch in expresion)
            {
                if (ch == '(')
                {
                    countOpenBracket++;
                }
                else if (ch == ')')
                {
                    countClosedBracket++;
                }
            }
            if (countOpenBracket == countClosedBracket)
            {
                Console.WriteLine("Your expression is valid");
            }
            else
            {
                Console.WriteLine("Your expression is invalid");
            }
        }
    }
}