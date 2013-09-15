using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
05 Write a program to convert hexadecimal numbers to binary numbers (directly).
ОБЯСНЕНИЕ: В учебника в главата "Бройни системи" е обяснено досатъчно ясно как директно става преминаването от едната бройна система в другата, затова няма да го повтарям тук. Четем шестнайсетичното число. Записваме го в масив от чарове (ползваме ToUpper, за да направим главни буквите, ако потребителя ги е въвел малки във входа) с помощта на ToCharArray().
Ще използваме StringBuilder, в който ще си складираме съвпаденията между 4 бита и цифрите от 0-9 и буквиет от А до F, който са складиране в  switch-case конструкцията (може да се използва и Dictionary)..

*/

namespace _05_ConvertHexidecimalToBinary
{
    class ConvertHexidecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please enter hexadecimal number:");
            string hexNum = Console.ReadLine();

            char[] hexChar = hexNum.ToUpper().ToCharArray();
            StringBuilder hexStr = new StringBuilder();

            for (int i = 0; i < hexChar.Length; i++)
            {
                switch (hexChar[i])
                {
                    case 'A': hexStr.Append(" 1010"); break;
                    case 'B': hexStr.Append(" 1011"); break;
                    case 'C': hexStr.Append(" 1100"); break;
                    case 'D': hexStr.Append(" 1101"); break;
                    case 'E': hexStr.Append(" 1110"); break;
                    case 'F': hexStr.Append(" 1111"); break;
                    case '0': hexStr.Append(" 0000"); break;
                    case '1': hexStr.Append(" 0001"); break;
                    case '2': hexStr.Append(" 0010"); break;
                    case '3': hexStr.Append(" 0011"); break;
                    case '4': hexStr.Append(" 0100"); break;
                    case '5': hexStr.Append(" 0101"); break;
                    case '6': hexStr.Append(" 0110"); break;
                    case '7': hexStr.Append(" 0111"); break;
                    case '8': hexStr.Append(" 1000"); break;
                    case '9': hexStr.Append(" 1001"); break;
                }
            }
        Console.WriteLine("The binary number is: {0}", hexStr);
        }
    }
}