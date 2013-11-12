using System;


/*
05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

ОБЯСНЕНИЕ: Задачата е обяснена достатъчно подробно от трейнърите във видеата към лекцията от курса.

 */

class FindThirdBitOfInt
{
    static void Main()
    {

        Console.WriteLine("Insert number: ");
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int result = mask & number;
        result = result >> 3;

        if (result == 1)
        { 
            Console.WriteLine("The bit 3 of a given number is 1");
        }

        else
        {
            Console.WriteLine("The bit 3 of a given number is 0");
        }
    }
}
