//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them 
//using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GetMaxOfThreeMethod
{
    class GetMaxOfThreeMethod
    {
        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert 3 numbers to compare them:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.Write("The bigest of three is: ");
            Console.WriteLine(GetMax(GetMax(a, b), c));
        }
    }
}

//ОБЯСНЕНИЕ: За създаването на условието в GetMax метода реших да използвам един тернарен оператор. След това нещата са лесни - въвеждаме си 
//3 числа от конзолата и с GetMax можете да видите в кода как намираме, кое е най-голямото.