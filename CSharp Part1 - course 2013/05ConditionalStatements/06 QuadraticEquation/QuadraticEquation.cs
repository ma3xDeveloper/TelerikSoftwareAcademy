using System;

/* 
 
06. Write a program that enters the coefficients a, b and c of a quadratic equation 
a*x2 + b*x + c = 0
and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

ОБЯСНЕНИЕ: Задачата не е слошна, но за целта трябва да се поровите отново из прашните учебници от училище по математика, 
за да си припомните за какво аджеба всъщност ставше дума в това квадратно уравнение и какви бяха тия негови корени.
 
 */

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Program for calculating quadratic equation...\n");
        Console.WriteLine("Please enter coefficients a,b and c\n");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double d = (b * b) - 4 * a * c;
        if (d > 0)
        {
            double x1 = (-b - Math.Sqrt(d)) / 2 * a;
            double x2 = (-b + Math.Sqrt(d)) / 2 * a;
            Console.WriteLine("The equation has two roots x1= {0} and x2= {1}", x1, x2);
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("The equation has one root x= {0}", x);
        }
        else
        {
            Console.WriteLine("The equation has no real roots");
        }
    }
}
