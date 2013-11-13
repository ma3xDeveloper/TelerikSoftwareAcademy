using System;

class ThteeIntPrintsTheirSum

/*
01. Write a program that reads 3 integer numbers from the console and prints their sum

ОБЯСНЕНИЕ: Четем последователно три числа от конзолата, като парсвайки ги към int, ги записваме в три променливи. 
Тези три променливи след това ги сумираме и изписваме резултата на конзолата.

*/
{
    static void Main()
    {
        Console.WriteLine("Enter first number here: ");
        int numberFirst = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number here: ");
        int numberSecond = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number here: ");
        int numberThird = int.Parse(Console.ReadLine());

        int sum = numberFirst + numberSecond + numberThird;

        Console.WriteLine("Thse sum of entered three numbers is: {0}", sum);

    }
}
