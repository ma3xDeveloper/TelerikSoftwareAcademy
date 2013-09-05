using System;

/*
2Write a program that reads a string, reverses it and prints the result at the console.

ОБЯСНЕНИЕ: Преобразуваме с ToCharArray() елементите от стринга в масив от чарове и след това с Array.Reverse() ги обръщаме.

*/

namespace _02_ReversesString
{
    class ReversesString
    {
        static void Main()
        {
            string text = "Elrond: Cast it into the fire! Destroy it!";
            char[] charr = text.ToCharArray();
            Array.Reverse(charr);
            Console.WriteLine(charr);
        }
    }
}
