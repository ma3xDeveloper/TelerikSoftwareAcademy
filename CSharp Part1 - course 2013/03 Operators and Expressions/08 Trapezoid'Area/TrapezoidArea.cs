using System;


/*
08. Write an expression that calculates trapezoid's area by given sides a and b and height h.

ОБЯСНЕНИЕ: За тази задача ще ни е необходима формулата за намиране на лице на трапец (http://bg.wikipedia.org/wiki/%D0%A2%D1%80%D0%B0%D0%BF%D0%B5%D1%86).

 */

class TrapezoidArea 
{
    static void Main()
    {
        Console.WriteLine("Insert a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert h:");
        int h = int.Parse(Console.ReadLine());

        Console.WriteLine("Area: ");
        Console.WriteLine((a + (b - a) / 2) * h);
    }
}
