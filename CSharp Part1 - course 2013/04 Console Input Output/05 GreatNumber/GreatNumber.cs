using System;

class GreatNumber

/*
05. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

ОБЯСНЕНИЕ: В тази задача се изисква от нас да въведем две числа и да изпишем на конзолата по-голямото от тях без да използваме условни конструкции. 
Първият начин е да използваме тернарен оператор. Вторият начин, който според мен е и целта на задачата, е да използваме и разберем как работи Math.Max() методът в C#. 
Неговата работа е като му подадем аргументите и той автоматично да ни каже кой е по-големият от тях.

*/
{
    static void Main()
    {
        Console.WriteLine("Please enter 2 numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("The greater numbers is: ");
        Console.WriteLine(Math.Max(a, b));
    }
}
