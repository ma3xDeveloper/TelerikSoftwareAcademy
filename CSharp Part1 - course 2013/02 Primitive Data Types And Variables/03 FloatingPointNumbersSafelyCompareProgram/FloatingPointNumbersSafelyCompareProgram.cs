using System;

/*
3. Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

ОБЯСНЕНИЕ: Целта тук е реално да се убедим в прецизността на float променливата до 7-мата цифра. Въвеждаме две числа в конзолата, парсваме ги към float и ги сравняваме.

 */

class FloatingPointNumbersSafelyCompareProgram
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        bool areEqual = firstNumber == secondNumber;
        Console.WriteLine("Are equal: " + areEqual);
    }
}
