using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
01 Write a program to convert decimal numbers to their binary representation.

ОБЯСНЕНИЕ: Алгоритъмът за преминаване от десетична в двуична бройна система е ясен. Имплементацията му може да се напише по следния начин: първо си правим една list променлива със StringBuilder, в която да складираме остатъците при делението. Използваме StringBuilder, защото е по-бърз от List<T> при работа с чарове.
Докато nunber е различно от 0, изпълняваме кода в while цикъла, а именно - в list записваме остатците при деление на 2, а самото число number си го разделяме на основата на бройната система - 2.
Накрая с един for цикъл, печатаме lista от чарове в ОБРАТЕН ред, за да получим желаното число в бинарен вид.
*/

namespace _01_ConvertDecimalToBinary
{
    class ConvertDecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please enter decimal number:");
            int number = int.Parse(Console.ReadLine());
            StringBuilder list = new StringBuilder();
            
            while (number != 0)
            {
                list.Append(number % 2);
                number /= 2;
            }

            for (int i = list.Length - 1; i > -1; i--)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
