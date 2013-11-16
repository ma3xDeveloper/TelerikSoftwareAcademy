using System;

/* 
 
03. Write a program that finds the biggest of three integers using nested if statements.

ОБЯСНЕНИЕ: За да намерим кое от трите числа е най-голямото ще използваме вложено if условие, в друго if условие. Например, ако числото "а" е по-голямо от "b" се отправяме към вложеното if условие, при което ако "а" е и по-голямо и от "с", 
това ще рече че именно "а" е най-голямото число от трите и изписваме това на конзолата.
 
 */

class BiggestOfThreeInts
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
        }
        if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
        }
        if (c > a)
        {
            if (c > b)
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
        }
    }
}
