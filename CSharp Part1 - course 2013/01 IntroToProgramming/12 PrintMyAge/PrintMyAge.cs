using System;

/*
12* Write a program to read your age from the console and print how old you will be after 10 years.

ОБЯСНЕНИЕ: Задачата с повишена трудност към домашното има за цел да запише нашата възраст и програмата да пресметне на колко години ще сме след 10 г.
Четем от конзолата на колко години сме и записваме стойността в една int променлива. След това просто добавяме 10 към стойността и така намираме търсената бъдеща възраст.
*/

class PrintMyAge
{
    static void Main()
    {
        Console.Write("What is your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Aften 10 years you'll be {0} years old", age + 10);
    }
}
