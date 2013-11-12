using System;


/*
12. We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	n = 5 (00000101), p=2, v=0 -> 1 (00000001)


ОБЯСНЕНИЕ:

 */

class ChangeNBit
{
    static void Main()
    {
        Console.WriteLine("Insert number here: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert value here (0 or 1): ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert position here: ");
        int position = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask0 = ~(1 << position);
            int result0 = mask0 & number;

            Console.WriteLine(result0);
        }
        else if (value == 1)
        {
            int mask1 = 1 << position;
            int result1 = number | mask1;

            Console.WriteLine(result1);
        }
        else
        {
            Console.WriteLine("Error!");
        }
     }
}
