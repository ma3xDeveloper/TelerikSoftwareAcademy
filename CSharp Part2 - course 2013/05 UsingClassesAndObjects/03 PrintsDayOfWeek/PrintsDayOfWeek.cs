using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//03 Write a program that prints to the console which day of the week is today. Use System.DateTime.

//ОБЯСНЕНИЕ: Задача, чиято цел е да упражним още един от системните класове на .NET - този път това е System.DateTime.

namespace _03_PrintsDayOfWeek
{
    class PrintsDayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is {0}", today.DayOfWeek);
        }
    }
}
