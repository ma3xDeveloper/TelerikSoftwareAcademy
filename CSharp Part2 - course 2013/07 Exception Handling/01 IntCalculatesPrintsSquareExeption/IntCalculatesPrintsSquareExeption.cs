using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IntCalculatesPrintsSquareExeption

/*
01 Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, 
print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

ОБЯСНЕНИЕ: Лесна задача като за първа, ако сте внимавали в лекцията за Обработка на изключения, вероятно сте разбрали, че можете да научите кои са най-честите изключения (грешки, ексепшъни),
 които различните методи са в състояние да хвърлят, чисто и просто като задържите мишката си над техните имена. За настоящата задача си избрах само два ексепшъна, които кода да се опита да хване.
 Ако е всичко е подадено коректно се изпълнява кода от finally блока.
*/
{
    class IntCalculatesPrintsSquareExeption
    {
        static void Main()
        {
            Console.WriteLine("Insert a valid integer number:");

            try
            {
                uint n = uint.Parse(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(n));
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}




