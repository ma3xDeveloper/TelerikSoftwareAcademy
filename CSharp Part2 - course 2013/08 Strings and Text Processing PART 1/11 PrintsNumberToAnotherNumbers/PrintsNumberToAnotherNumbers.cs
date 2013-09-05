using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PrintsNumberToAnotherNumbers
{
    class PrintsNumberToAnotherNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a nubmer:");
            int number = int.Parse(Console.ReadLine());
            string result = string.Format("{0,15:D}\n{0,15:X4}\n{0,15:P0}\n{0,15:E}", number);
            Console.WriteLine(result);
        }
    }
}
