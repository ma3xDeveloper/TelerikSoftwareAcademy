using System;

class CirclePerimeterArea

/*
02. Write a program that reads the radius r of a circle and prints its perimeter and area.

ОБЯСНЕНИЕ: Задача, аналогична на горната, само че тук трябва да си припомним формулите от училище за намиране на периметър и лице на окръжност.

 */
{
    static void Main()
    {
        Console.Write("Please enter circle's radius: ");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * (r * r);
        double perim = Math.PI * (2 * r);
        Console.WriteLine("The area of the circle is: {0}\nThe perimeter of circle is {1}", area, perim);
    }
}
