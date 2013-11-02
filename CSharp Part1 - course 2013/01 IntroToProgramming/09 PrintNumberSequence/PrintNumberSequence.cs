using System;

/*
09 Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

ОБЯСНЕНИЕ: За решението на тази задача съм използвал for цикъл, който принтира 10-те числа. 
Тъй като обаче темата за циклите е сравнително делечна и ще бъде изучавана понатам в курса, то за решението на задачата със знанията, които имате към настоящия момент, може просто да използвате Console.WriteLine() и да изредите поредицата от 10-те числа.
*/

class PrintNumberSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("-" + i);
            }
        }
    }
}
