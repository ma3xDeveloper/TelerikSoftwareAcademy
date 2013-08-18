using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReadNumberExceptionAnd10Numbers

/*
02 Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
 If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
 a1, a2, … a10, such that 1 < a1 < … < a10 < 100


ОБЯСНЕНИЕ: Задача с малко неясно формулирано условие, от което в първия момент човек не може да се ориентира какво точно се изисква от него.
 Ето как аз успях да си го разкодирам и обясна: При стартирането на козолата, трябва ръчно да зададете долна и горна граница на някакъв интервал от числа. След което
 трябва да извикате метод, който да поиска от вас да въведете 10 числа на конзолата, като първото условие е тези числа да са в интервала, който по-горе сте задали и второт условие е всяко следващо въведено число да е по-голямо от предишните въведени.
 В случай на неизпълнение на някой от тези условия - програмата трябва да прихваща и изплюва съответните грешки. 
*/

{
    class ReadNumberExceptionAnd10Numbers
    {
        private static void Print10Numbers(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < start || n > end)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter number in range [start...end]");
                Console.Write("Enter number for start: ");

                int start = int.Parse(Console.ReadLine());

                Console.Write("Enter number for end: ");

                int end = int.Parse(Console.ReadLine());

                Console.WriteLine("Please star to enter the numbers in that range:");


                Print10Numbers(start, end);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Your number is out of range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number is too big!");
            }
        }
    }
}