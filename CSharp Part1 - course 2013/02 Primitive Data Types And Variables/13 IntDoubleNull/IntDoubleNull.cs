using System;

/*
13. Create a program that assigns null values to an integer and to double variables. 
    Try to print them on the console, try to add some values or the null literal to them and see the result.

ОБЯСНЕНИЕ: Добавяне на стойност null към числови променливи става чрез добавяне на символа "?" - например int?. Когато се опитаме да съберем null с число резултатът е null, тъй като Visual Studio не знае как да събере число с "нищо". 
Null е резулатът, ако се опитаме да съберем и null с null.


 */

class IntDoubleNull
{
    static void Main()
    {
        int? integerNull = null;
        double? doubleNull = null;
        Console.WriteLine("integerNull = {0}", integerNull + 5);
        Console.WriteLine("doubleNull = {0}", doubleNull + null);
    }
}