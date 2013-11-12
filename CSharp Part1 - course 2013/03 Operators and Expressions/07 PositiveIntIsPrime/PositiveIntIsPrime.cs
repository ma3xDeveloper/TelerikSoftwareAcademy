using System;


/*
07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

ОБЯСНЕНИЕ: За тази задача трябва да си припомним какво представляваха простите числа (http://bg.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D1%81%D1%82%D0%BE_%D1%87%D0%B8%D1%81%D0%BB%D0%BE).
След което да направим условие, което да проверява дали числото отговаря на изискванията, то да е просто. Ако да - булевата променлива ще бъде със стоност true.

 */


class PositiveIntIsPrime
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
         
        bool isPrime = ((number % 2 > 0) 
            && (number % 3 > 0) && (number % 5 >0)
            && (number % 7 > 0)) || ((number == 2) || (number == 3)
            || (number == 5) || (number == 7));

    Console.WriteLine(isPrime);
    }
}