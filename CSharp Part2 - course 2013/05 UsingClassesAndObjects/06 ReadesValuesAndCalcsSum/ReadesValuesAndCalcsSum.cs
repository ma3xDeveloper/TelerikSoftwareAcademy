using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
06 You are given a sequence of positive integer values written into a string, separated by spaces. 
Write a function that reads these values from given string and calculates their sum. Example:
string = "43 68 9 23 318" --> result = 461

ОБЯСНЕНИЕ: Имаме стринг от числа, разделени помежду си от спейсове и трябва да съберем тези числа. Ползваме input.Split(' '), за да разцепим стринга по интервалите му,
 след което, с помощта на един foreach цикъл, прилагаме за всеки един разцепен елемент int.Parse() и накрая просто събираме сумата им. 
*/

namespace _06_ReadesValuesAndCalcsSum
{
    class ReadesValuesAndCalcsSum
    {
        static void Main()
        {
            string input = "43 68 9 23 318";
            string[] numbers = input.Split(' ');
            int sum = 0;
            foreach (string p in numbers)
            {
                sum += int.Parse(p);
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}