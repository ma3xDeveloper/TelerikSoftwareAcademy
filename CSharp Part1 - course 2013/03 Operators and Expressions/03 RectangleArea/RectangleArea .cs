using System;


/*
03. Write an expression that calculates rectangle’s area by given width and height.

ОБЯСНЕНИЕ: Тук ще трябва да упражните операторът умножение (*) и да си припомните, коя беше формулата за намиране на лице квадрат ;)

 */

class Program
{
    static void Main()
    {
        Console.WriteLine("Insert rectangle’s WIDTH: ");
        int numberWidth = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert rectangle’ HEIGHT: ");
        int numberHeight = int.Parse(Console.ReadLine());

        int resultArea = numberWidth * numberHeight;

        Console.WriteLine("Rectangle’s area is: {0}", resultArea);
    }
}
