using System;

/* 
 
02. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
 
ОБЯСНЕНИЕ: Иска се да намерим какъв ще е знакът (+ ли -) от произведението на три числа, БЕЗ обаче да извършваме самото произведение. Следователно въпросът е при какви случай имаме резултат равен на 0, отрицателен или положителен?
Ако едно от числата е равно на нула, то тогава и самото произведение ще е равно на нула. Ако имаме три отрицателни числа, то и тяхното поризведение ще е отрицателно. 
Положителен резултат имаме, когато и когато само едно от числата е положително и когато всички заедно са такива. И така, четем от конзолата три числа. След това записваме в булеви променливи дали те са по-гоеми от нула.
След това с помощта на оператора XOR извършваме проверката в if условието.

 */

class ProductofThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool aCheckSign = a > 0;
        bool bCheckSign = b > 0;
        bool cCheckSign = c > 0;
 
        if (aCheckSign ^ bCheckSign ^ cCheckSign)
        {
            Console.WriteLine("The sign will be \"+\"");
        }
        else
        {
            Console.WriteLine("The sign will be \"-\"");
        }
    }
}

