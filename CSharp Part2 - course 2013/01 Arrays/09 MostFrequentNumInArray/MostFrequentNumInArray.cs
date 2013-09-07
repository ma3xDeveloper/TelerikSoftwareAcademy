using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MostFrequentNumInArray
{
    class MostFrequentNumInArray
    {
        static void Main(string[] args)
        {
            //Write a program that finds the most frequent number in an array

            Console.Write("Enter length of the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] array1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Element[{0}]=", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] >= array1[j])
                    {
                        int a = array1[i];
                        array1[i] = array1[j];
                        array1[j] = a;
                    }
                }
            }
            int counter = 0;
            int bigCounter = 0;
            int whatNum = 0;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] == array1[i + 1])
                {
                    counter++;
                    if (bigCounter <= counter)
                    {
                        bigCounter = counter;
                        whatNum = array1[i];
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            Console.WriteLine("We have {0} members of the number \"{1}\" in the array", bigCounter + 1, whatNum);
        }
    }
}

    //ОБЯСНЕНИЕ: С първите два for цикъла първо подреждаме самия масив от числа във възходящ ред. Стандартен алгоритъм за сортиране си е това, нищо сложно.
    //След което правим класическите три променливи, в които да отброяваме: броя на повторенията към момента, най-голямото повтериение и самото число, което е с най-голямото повторение.
    //Пускаме трети for цикъл, с който започваме да с сравняваме един по един елементите по елементите из масива и съответно ако има еднакви числа в поредица едно до друго if и else конструкцията в кода се грижат за това накрая конзолата да ни ги изпечата правилното решение на задачата.