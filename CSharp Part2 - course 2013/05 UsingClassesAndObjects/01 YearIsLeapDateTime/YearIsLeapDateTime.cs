using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//01 Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

//ОБЯСНЕНИЕ: В тази задача най-лесно е да изпробваме специално предвидения в .NET за целта системен клас DateTime.IsLeapYear, който е предвиден да връща булев резултат, в зависимост от който изписваме на кознозолата, 
//дали годината е високосна или не.

namespace _01_YearIsLeapDateTime
{
    class YearIsLeapDateTime
    {
        static void Main()
        {
            Console.Write("Please enter year to check: ");
            bool isLeap = DateTime.IsLeapYear(int.Parse(Console.ReadLine()));

            if (isLeap == true)
            {
                Console.WriteLine("The year is Leap");
            }

            else
            {
                Console.WriteLine("The yea is NOT a Leap");
            }
        }
    }
}
