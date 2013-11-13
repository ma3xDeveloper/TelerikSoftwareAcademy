using System;

class Equation

/*
06. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

ОБЯСНЕНИЕ: Нищо сложно няма тук - просто трябва да се поровим и припомним как се решаваше квадратно уравнение в училище с всичките му там екстри като дискриминанта и т.н. и да използваме формулите му в кода.

*/
{
    static void Main()
    {
        Console.WriteLine("Program for calculating quadratic equation...");
        Console.WriteLine("Please enter coefficients a, b and c: ");
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
            int x = -b / (2 * a);
            Console.WriteLine("The equation has one root x= {0}", x);
        }
        else
        {
            Console.WriteLine("The equation has no real roots");
        }
    }
}
