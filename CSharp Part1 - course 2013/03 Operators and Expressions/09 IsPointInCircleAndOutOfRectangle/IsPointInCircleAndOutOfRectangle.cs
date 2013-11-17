using System;


/*
09. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

ОБЯСНЕНИЕ: В тази задача трябва да проверим дали кординатите x и y се намират едновременно в дадената окръжност и същевременно извън дадения правоъгълник. 
За целта ще трябва да преизползваме формулата от 6-та задача за намиране на точка в окръжност: x² + y² < r² и да добавим формула, която да проверява дали координатите са извън правоъгълника.
 
 */

class IsPointInCircleAndOutOfRectangle
{
    static void Main()
    {

        Console.Write("Please enter X coordinate: ");
        decimal x = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter Y coordinate: ");
        decimal y = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        bool result = (((x - 1)*(x - 1) + (y - 1)*(y - 1)) <= 9) && ((x < -1) || ((x >= -1) && ((y <= -1) || (y >= 1))));
        Console.WriteLine("The coordinates are inside the circle and out of the rectangular: {0}", result);
    }
}
