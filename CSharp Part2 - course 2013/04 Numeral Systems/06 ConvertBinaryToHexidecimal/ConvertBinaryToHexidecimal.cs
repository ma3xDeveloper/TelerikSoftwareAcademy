using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
06 Write a program to convert binary numbers to hexadecimal numbers (directly).

ОБЯСНЕНИЕ: Решението е подобно на предишната задача. Четем бинарното число от конзолата. Взимаме дължината на елементите му и я записваме в strLength.
С for цикъла на четри стъпки с помощта на Substring (той взима от даде стринг точно определен рамер подстринг), разделяме поредицата от нули и единици, които от switch-case им намираме съответните
еквиваленти от 0 до 9 и от A до F и ги вкарваме в StringBuilder-а с помощтта на Append().
*/

namespace _06_ConvertBinaryToHexidecimal
{
    class ConvertBinaryToHexidecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter binary number:");
            string binNum = Console.ReadLine();

            int strLength = binNum.Length;
            StringBuilder hexNum = new StringBuilder();

            for (int i = 0; i < strLength; i = i + 4)
            {
                switch (binNum.Substring(i, 4))
                {
                    case "1010": hexNum.Append("A"); break;
                    case "1011": hexNum.Append("B"); break;
                    case "1100": hexNum.Append("C"); break;
                    case "1101": hexNum.Append("D"); break;
                    case "1110": hexNum.Append("E"); break;
                    case "1111": hexNum.Append("F"); break;
                    case "0000": hexNum.Append("0"); break;
                    case "0001": hexNum.Append("1"); break;
                    case "0010": hexNum.Append("2"); break;
                    case "0011": hexNum.Append("3"); break;
                    case "0100": hexNum.Append("4"); break;
                    case "0101": hexNum.Append("5"); break;
                    case "0110": hexNum.Append("6"); break;
                    case "0111": hexNum.Append("7"); break;
                    case "1000": hexNum.Append("8"); break;
                    case "1001": hexNum.Append("9"); break;
                }
            }
            
            Console.WriteLine("The hexadecimal number is: {0}", hexNum);
        }
    }
}