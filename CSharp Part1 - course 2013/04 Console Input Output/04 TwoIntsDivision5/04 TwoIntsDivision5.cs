using System;

class TwoIntsDivision5

/*
04. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive).
    Example: p(17,25) = 2.

ОБЯСНЕНИЕ: Четем от конзолата две числа и ги записваме в променливите а и b. 
Правим си една int променлива, която я озаглавяваме count примерно и й даваме първоначална стойност 0 - в тази променлива ще записваме броя на числата между а и b, които след деление на 5 с остатък има остатък 0.
Правим си един for цикъл, който да извърти числата от а до b. Вътре слагаме if, чието условие е всеки път, когато попаднем на число, което след деление на 5 с остатък има остатък 0, то да се отброява в променливата count.
Накрая изпечатваме самата променлива и така виждаме бройката на търсените числа.

*/
{
    static void Main()
    {
        Console.WriteLine("Please enter first positive intiger number: "); 
        uint a = uint.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second positive intiger number: "); 
        uint b = uint.Parse(Console.ReadLine());
        
        int count=0;
        
        for (int i =(int) a; i <= b; i++)
        {
            if(i%5==0)
            {
                count++;
            }
        }
        Console.WriteLine("Numbers of p that exists in the interval {0} to {1} are: {2}",a,b,count);
        }
}
