using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
08 Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

*/

namespace _08__RepresentsShort
{
    class RepresentsShort
    {
        static void Main()
        {
            Console.Write("Please enter a short integer number: ");
            short n;
            short.TryParse(Console.ReadLine(), out n);
            Console.Write("The binary representation of the number is: ");
            Console.WriteLine(Convert.ToString(n, 2));
        }
    }
}
