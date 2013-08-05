using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//02 Write a program that generates and prints to the console 10 random values in the range [100, 200].

//ОБЯСНЕНИЕ: Използваме системния клас Random и неговия метод .Next за да кенерираме 10-те случайни числа. 
//Тъй като Random.Next има една особеност, в следстиве на която, ако му зададем параметри (100, 200), то тогава той би дал числа в интервала 100-199, 
//за да получим 10-те произволни числа в интервала от 100 до 200 трябва да му зададем параметри (100, 201).


namespace _02_Prints10RandomNumbers
{
    class Prints10RandomNumbers
    {
        static void Main()
        {
            Random randomNumber = new Random();
            Console.WriteLine("Ten random numbers are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", randomNumber.Next(100, 201));
            }
        }
    }
}
