using System;


/*
04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

ОБЯСНЕНИЕ: Задачата е подобна на първата, но по сложна, защото тук трябва да проверим дали 3-тата цифра отдясно-наляво в дадено число е равна на 7.
Това може да се провери чрез специален израз зададен като условие на if-else конструкцията: в скобите първо делим числото на 100 и тъй като работим с int той автоматично ще отреже всичко след десетичната запетая. След това делим с остатък,
и ако остатъкът е равен на 7, то значи и цифрата на 3-та позиция е равна на 7.

 */

class ExpressionCheck7
{
    static void Main()
    {
        Console.WriteLine("Insert number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine("The third digit (right-to-left) of number {0} is 7", number);
        }
        else
        {
            Console.WriteLine("The third digit (right-to-left) of number {0} is NOT 7", number);
        }
    }
}