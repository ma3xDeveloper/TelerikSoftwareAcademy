using System;


/*
11. Write an expression that extracts from a given integer "i" the value of a given bit number "b". Example: i=5; b=2 -> value=1.

ОБЯСНЕНИЕ: Почти същата задача като 10-та, пак се използва маска с шифтване.

 */

class ExtractIntGivenBit
{
    static void Main()
    {
        Console.WriteLine("Insert number here: ");
        int numberI = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert bit number here: ");
        int bitNumber = int.Parse(Console.ReadLine());

        int mask = 1 << bitNumber;
        int result = mask & numberI;
        result = result >> bitNumber;

        Console.WriteLine("Value: {0}", result);
    }
}