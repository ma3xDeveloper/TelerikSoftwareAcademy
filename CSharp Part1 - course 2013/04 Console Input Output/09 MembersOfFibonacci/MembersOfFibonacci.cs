using System;
using System.Numerics;

class MembersOfFibonacci

/*
09. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

ОБЯСНЕНИЕ: За тази задача, ще ни е небходима променлива, която да побере много голямо число. Ще използваме BigInteger, който се активира от namespace-a System.Numerics. 
За целта цъкаме с дясното копче на мишката върху References на нашия проект и от падащото меню избираме Add References. След това от прозореца се уверяваме, 
че сме  цъкнали горе в ляво на Assemblies, пишем в търсачката "Numerics" и като се появи using System.Numerics го активираме. Готово вече имаме на разположение BigInteger променливата, която може да побере меко казано огромни числа.
 
За да решим задачата е необходимо и да се запознаем с същността на числата на Фибоначи -  http://bg.wikipedia.org/wiki/%D0%A7%D0%B8%D1%81%D0%BB%D0%B0_%D0%BD%D0%B0_%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D0%B8

След това си създаваме три променливи, чрез чието подреждане и разменяне в един for цикъл принтираме на конзолата първите 100 числа от Фибоначи редицата.

*/
{
    static void Main()
    {
        Console.WriteLine("The first 100 members of Fibonacci sequence: ");

        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger neutralNum;

        Console.WriteLine(secondNum); // printing the first number of the sequence

        for (int i = 1; i < 100; i++)
        {
            neutralNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = neutralNum;
            Console.WriteLine(neutralNum);
        }
    }
}

