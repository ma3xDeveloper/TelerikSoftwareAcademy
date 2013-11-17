using System;


/*
13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

ОБЯСНЕНИЕ: Трябва да разменим битовете от позиция 3, 4 и 5 с тези от позиция 24, 25 и 26 на 32-битов UNSIGNED integer - т.е. ще използваме uint, който е unsigned и е 32-битов.
Използваме for цикъл, който да м ине през трите позиции на числото. Тъй като използваме unsigned integer вместо да изпишем числото 1 вътре из if условията на цикъла, изпозваме unsigned литерала 1U. 

 */

class ExchangeBits
{
    
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("The number binary representation is: ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine();

        for (int i = 3; i < 6; i++)
        {
            if ((number >> i & 1U) != (number >> (i + 21) & 1U))
            {
                if ((number >> i & 1U) == 1)
                {
                    number = ~(1U << i) & number;
                    number = (1U << (i + 21)) | number;
                }
                else
                {
                    number = (1U << i) | number;
                    number = ~(1U << (i + 21)) & number;
                }
            }
        }
        Console.Write("After exchanges the result is: ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}