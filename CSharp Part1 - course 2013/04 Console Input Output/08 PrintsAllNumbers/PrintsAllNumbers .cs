using System;

class PrintsAllNumbers

/*
08. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

ОБЯСНЕНИЕ: Задачата прилича на горната, с разликата че настройваме for цикъла да изпечата последователно числата от 1 до n върху конзолата.

*/
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}
