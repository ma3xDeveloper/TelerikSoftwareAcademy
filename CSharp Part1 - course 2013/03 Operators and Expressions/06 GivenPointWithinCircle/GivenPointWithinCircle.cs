using System;


/*
06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

ОБЯСНЕНИЕ: В тази задача, под K(O, 5) се разбира окръжност, центъра на която е центъра на координатната система и е с радиус 5. Ще използваме формулата за намиране на точка в окръжност, която е x² + y² < r²
За да повдигаме на квадрат няма да използваме методът Math.Pow, тъй като той е бавна функция.

 */

class GivenPointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Pease enter the X coordinate: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Pease enter the Y coordinate: ");
        decimal y = decimal.Parse(Console.ReadLine());

        decimal radius = 5;
        bool result = x * x + y * y < radius * radius;

        Console.WriteLine();
        Console.WriteLine(result ? "They are within the circle" : "They are outside the circle");
    }
}
