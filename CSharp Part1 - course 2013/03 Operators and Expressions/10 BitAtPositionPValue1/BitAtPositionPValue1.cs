using System;

/*
10. Write a boolean expression that returns if the bit at position "p" (counting from 0) in a given integer number "v" has value of 1. Example: v=5; p=1 -> false.

ОБЯСНЕНИЕ: Задачата е подобна на 5-та и отново се използва маска, която се шифтва.

 */

class BitAtPositionPValue1
{
    static void Main()
    {        
        Console.WriteLine("Insert number here: ");
        int numberV = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert position here: ");
        int positionP = int.Parse(Console.ReadLine());

        int mask = 1 << positionP;
        int result = mask & numberV;
        result = result >> positionP;

        if (result == 1)
        {
            Console.WriteLine("The bit at position {0} in a given integer number {1} has value of 1", positionP, numberV);
        }

        else if (result == 0)
        {
            Console.WriteLine("The bit at position {0} in a given integer number {1} has value of 0", positionP, numberV);
        }
    }
}
