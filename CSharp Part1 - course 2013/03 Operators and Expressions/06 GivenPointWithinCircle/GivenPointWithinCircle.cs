using System;


/*
06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

ОБЯСНЕНИЕ: За решението на тази задача се налага да се запознаете с Питагоровата теорема (http://en.wikipedia.org/wiki/Pythagorean_theorem) и да си направите сметките.

 */

class GivenPointWithinCircle
{
    static void Main()
    {
        decimal pointX = 4.6m;
        decimal pointY = - 4.3m;
        decimal centerX = - 1.0m;
        decimal centerY = 2.5m;

        decimal resultX = (pointX - centerX) * (pointX - centerX);
        decimal resultY = (pointY - centerY) * (pointY - centerY);

        decimal resultXY = resultX + resultY;

        decimal radius = 5;

        bool isWhitin = resultXY < radius * radius;

        Console.WriteLine(isWhitin);
    }
}
