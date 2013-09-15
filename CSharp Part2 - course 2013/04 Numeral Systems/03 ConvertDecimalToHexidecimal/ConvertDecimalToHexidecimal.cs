using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
03 Write a program to convert decimal numbers to their hexadecimal representation.

ОБЯСНЕНИЕ: Изоплзваме кода от първа задача. Различното тук е, че добавяме един switch, чрез който да добавяме буквиет от A до F, когато имаме остатъци при делението от 10 до 15.
С for цикъл печатаме StringBuilder list-а в обратен ред, за да получим числото в шеснайсетичения му вид.
*/

namespace _03_ConvertDecimalToHexidecimal
{
    class ConvertDecimalToHexidecimal
    {
        static void Main()
        {
       
            Console.WriteLine("Please enter decimal number:");
       
            int number = int.Parse(Console.ReadLine());

            StringBuilder list = new StringBuilder();
       
            while (number != 0)
       
            {
            if (number % 16 > 9)
            {
                switch (number % 16)
                {
                    case 10: list.Append("A");
                        break;
                    case 11: list.Append("B");
                        break;
                    case 12: list.Append("C");
                        break;
                    case 13: list.Append("D");
                        break;
                    case 14: list.Append("E");
                        break;
                    case 15: list.Append("F");
                        break;
                }
            }
            else
            {
                list.Append((number % 16).ToString());
            }
                number /= 16;
            }

            for (int i = list.Length - 1; i > -1; i--)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
