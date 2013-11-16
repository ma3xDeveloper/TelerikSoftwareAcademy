using System;

/* 
 
07. Write a program that finds the greatest of given 5 variables.

ОБЯСНЕНИЕ: Задачата е подобна на 3-та, само че тук се изисква да се открие най-голямото число от измежду пет. Това става отново чрез if-else конструкции, в които условията за проверка на 5-те числа са малко по-дългички.
 
 */

class GreatestOfFiveVariables
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 integer numbers");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
        {
            Console.WriteLine(number1);
        }
        else if (number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
        {
            Console.WriteLine(number2);
        }
        else if (number3 > number1 && number3 > number2 && number3 > number4 && number3 > number5)
        {
            Console.WriteLine(number3);
        }
        else if (number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
        {
            Console.WriteLine(number4);
        }
        else
        {
            Console.WriteLine(number5);
        }
    }
}
