using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_FacturielNumber
{
    class FactorialNumber
    {
        static BigInteger CalcualteFactorial(int[] array, int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * array[i];
            }
            return result;
        }

        static void Main()
        {
            int[] hundredNumbers = new int[100];
            for (int i = 1; i < 100; i++)
            {
                hundredNumbers[i] = i;

            }
            foreach (var item in hundredNumbers)
            {
                Console.WriteLine(CalcualteFactorial(hundredNumbers, item));
            }
        }
    }
}



//ОБЯСНЕНИЕ: Тук трябва да изчислим фактуриел от 100. Тъй като големината на числата ще нарастнат доста бързо, изчисляването на фактуриел изисква да ползваме BigInteger (виж задача 08, как се извикват). Формулата за фактуриел е ясна още от задачите в C#1, 
//можете оттам да си  я припомните. Особеното тук е че просто изнасяме формулата в отделен метод. И това е.