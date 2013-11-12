using System;


/*
02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

ОБЯСНЕНИЕ: Задача, подобна на  горната, но малко по сложна, защото тук вече трябва да използваме и оператора &&, с чиято помощ да си съставим условието в if-else конструкцията. 
Условието ще бъде true тогава и само тогава когато двете условия, които се намират от двете страни на оператора && биват изпълнени т.е. са true.

 */

class BooleanExpressionDividedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Insert number here: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number can be divided (without remainder) by 7 and 5 in the same time");
        }
        else
        {
            Console.WriteLine("The number can NOT be divided (without remainder) by 7 and 5 in the same time");
        }
    }
}
