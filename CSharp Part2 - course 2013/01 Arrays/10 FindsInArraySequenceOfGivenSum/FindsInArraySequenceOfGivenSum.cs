using System;
using System.Text;
using System.Threading.Tasks;

namespace _10_FindsInArraySequenceOfGivenSum
{
    class FindsInArraySequenceOfGivenSum
    {
        static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present). 
            //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

            int[] array = { 4, 3, 1, 4, 2, 5, 8 };

            Console.WriteLine("Enter sumS:");
            int sumS = int.Parse(Console.ReadLine());
            int currentSum = array[0];

            int startIndex = 0;
            int endIndex = 0;
            int CurrSum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                CurrSum += array[i];
                startIndex = i;
                for (int p = i + 1; p < array.Length; p++)
                {
                    CurrSum += array[p];
                    endIndex = p;
                    if (CurrSum == sumS)
                    {
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.WriteLine(array[k]);
                        }
                        return;
                    }
                }
                CurrSum = 0;
            }
            Console.WriteLine("The sumS is not present in the array.");
        }
    }
}

/*
ОБЯСНЕНИЕ: Тук търсим в масив последователна поредица от числа, чиято сума да е равна на числото S. Правим си три променливи по подобие на 8-ма задача: startIndex, endIndex, CurrSum.
С два for цикъла обхождаме масива събирайки отляво-надясно елементите му. В момента, в който открием елементи, чиято сума да удовлетворява if условието (а именно - временната CurrSum да бъде равна на sumS)
влизаме в третия for цикъл, който ни отпечатва индексите (startIndex e нейното начало, а endIndex нейния край) на търсената поредица от числа. Ако не намерим такава поредица от елементи - изписваме, че в масива няма такава поредица.
*/