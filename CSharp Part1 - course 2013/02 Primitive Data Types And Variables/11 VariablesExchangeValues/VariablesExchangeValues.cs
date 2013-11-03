using System;

/*
10. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

ОБЯСНЕНИЕ: Много важна задача, чиято основна цел е да ни научи как да разменим стойностите на две променливи (в случая int). За по-голяма нагледност и улеснение на примера съм използвал семпли имена на променливите.

 */

class VariablesExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}