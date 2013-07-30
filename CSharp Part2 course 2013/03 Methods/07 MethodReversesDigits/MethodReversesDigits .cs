//Write a method that reverses the digits of given decimal number. 
//Example: 256  652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MethodReversesDigits
{
    class MethodReversesDigits
    {
        public static int ReverseNumber(int number)
        {
            int tempNumber = 0;
            while (number > 0)
            {
                tempNumber = (tempNumber * 10) + (number % 10);
                number /= 10;
            }
            return tempNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to reverse");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));
        }
    }
}

//ОБЯСНЕНИЕ: доста лесна задача на нивото от C# part 1. Четем число от конзолата, на което да обърнем числата.
//В ReverseNumber метода използваме просто while условие, в което изпълняваме просто условие, чиято същина са особеностите на оператора 
//"%" (т.нар. делиение с остатък, при което като разделим остава числото след запетаята) и "/" (т.нар. целочислено деление, при което след разделянето остава числото преди запетаята).
//След изпълнението на while цикъла, променливата tempNumber съдържа вече обърнатото число и след това го печатаме на конзолата.