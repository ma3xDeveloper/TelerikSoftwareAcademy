using System;

class NumbersSum

/*
07. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

ОБЯСНЕНИЕ: Тази задача прилича доста на начинът, по който се инициализират масивите. В случая от нас се иска да зададем едно първоначално число N. След това с помощта на един for цикъл
въвеждате N на брой произволни числа, които автоматично се сумират в променливата sum.

*/
{
    static void Main()
    {
        Console.WriteLine("Please enter N-numbers to be summed: ");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;

        Console.WriteLine("Please enter the numbers: ");
        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of entered numbers is {0}\n", sum);
    }
}
