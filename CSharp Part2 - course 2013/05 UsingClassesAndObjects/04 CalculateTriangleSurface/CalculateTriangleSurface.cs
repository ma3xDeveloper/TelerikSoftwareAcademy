using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*04 Write methods that calculate the surface of a triangle by given: side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

ОБЯСНЕНИЕ: Откровено казано, малко досадна задача, тъй като ще се наложи да си припомняте навярно доста позабравени от училищните години формули. 
В общи линии от нас се изисква да изчислим лицето на триъгълник според три различни случая: 
1. при дадена страна и височина; 
2. при три дадени страни;
3. при две страни и ъгъл между тях. 
 
За първия случай ще използваме следната формула: S = (a * h) / 2
 
За втория случай използваме т.нар. Херонова формула - http://bg.wikipedia.org/wiki/%D0%A5%D0%B5%D1%80%D0%BE%D0%BD%D0%BE%D0%B2%D0%B0_%D1%84%D0%BE%D1%80%D0%BC%D1%83%D0%BB%D0%B0
При Хероновата формула е важно да бъде изпълнено следното условие: a + b > c.
 
За третия случай използваме Math.sin като за него ъгълът трябва да е в радиани - http://bg.wikipedia.org/wiki/%D0%A0%D0%B0%D0%B4%D0%B8%D0%B0%D0%BD.
Умножаваме го по Пи и го разделяме на 180.
*/

namespace _04_CalculateTriangleSurface
{
    class CalculateTriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("How to calculate the area of triangle?\n");
            Console.WriteLine("1. By side and altitude.\n2. By three sides\n3. Two sides and an angle between them.");
            int choiceMethod = int.Parse(Console.ReadLine());

            switch (choiceMethod)
            {
                case 1: AreaBySideAndAltitude();
                    break;
                case 2: AreaByThreeSides();
                    break;
                case 3: AreaByTwoSidesAndAngle();
                    break;
                default: Console.WriteLine("Error! Enter correct number!");
                    break;
            }
        }

        private static void AreaBySideAndAltitude()
        {
            Console.WriteLine("Enter a side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a altitude:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("S = {0}", a * h / 2);
        }

        private static void AreaByThreeSides()
        {
            Console.WriteLine("Enter a first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third side:");
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            Console.WriteLine("S = {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        private static void AreaByTwoSidesAndAngle()
        {
            Console.WriteLine("Enter a first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an angle:");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("S = {0}", a * b * Math.Sin(Math.PI * angle / 180) / 2);
        }
    }
}
