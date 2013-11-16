using System;

/* 
 
04. Sort 3 real values in descending order using nested if statements.

ОБЯСНЕНИЕ: Тази задача прилича малко на предишната, с разликата че вложеното if условие е една идея по-дълго, заради допълнителната проверка на оставащите 2 числа.
 
 */

class ThreeRealValuesDescendingOrder 
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a > b)
        {
            if (a > c)
            {
                Console.Write(a);
                if (b > c)
                {
                    Console.Write(" {0} {1}", b, c);
                }
                else if (c > b)
                {
                    Console.Write(" {0} {1}", c, b);
                }
            }
        }
        else if (b > c)
        {
            if (b > a)
            {
                Console.Write(b);

                if (a > c)
                {
                    Console.Write(" {0} {1}", a, c);
                }
                else if (c > a)
                {
                    Console.Write(" {0} {1}", c, a);
                }
            }
        }
        else if (c > a)
        {
            if (c > b)
            {
                Console.Write(c);

                if (a > b)
                {
                    Console.Write(" {0} {1}", a, b);
                }
                else if (b > a)
                {
                    Console.Write(" {0} {1}", b, a);
                }
            }
        }
        Console.WriteLine();
    }
}
