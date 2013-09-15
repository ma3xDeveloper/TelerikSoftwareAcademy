using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
02 Write a program to convert binary numbers to their decimal representation.

ОБЯСНЕНИЕ: Записваме числото, което ще преобразуваме от двуична в десетична система в стринга number (ще използваме този стринг като масив, който съдържа нашите числа на двуичното число - нули и единици).
В променливата decNumber ще сумираме крайното десетично число, по метода който е приет за конвертиране от двоична в десетична бройна система. В index ще пазим на коя позиция в стринга се намираме и съответно на коя степен да повдигаме.
Във for цикъла се извършва повдигането на съответната степен и сумирането. След това печатаме резултата.
 */

namespace _02_ConvertBinaryToDecimal
{
    class ConvertBinaryToDecimal
    {
        static void Main()
        {
             Console.WriteLine("Please enter binary number:");
             string number = Console.ReadLine();
             int decNumber = 0;
             int index = 0;
             
             for (int i = number.Length-1; i >= 0; i--)
                {
                 decNumber+=(int)(int.Parse(number[i].ToString())*Math.Pow(2,index));
                 index++;
                }

            Console.WriteLine(decNumber);
        }
    }
}
