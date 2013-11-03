using System;

/*
8. Declare two string variables and assign them with following value: "The "use" of quotations causes difficulties."
   Do the above in two different ways: with and without using quoted strings.

ОБЯСНЕНИЕ: Тук към две string променливи трябва да присвоим следната стойност (изречение) - The "use" of quotations causes difficulties.
Уловката е че в изречението има кавички, които трябва да се изпечатат на конзолата. Това може да стане по два начина. Първият е със слагането на "@" пред изречението, което автоматично изпечатва стринга (изречението) така както искаме.
Вторият е чрез т.нар. ескейпване (escaping) на кавичките в изречението чрез симвоа "\".

 */

class QuotedStrings
{
    static void Main()
    {
        string varianDemotOne = @"The ""use"" of quotations causes difficulties";
        string variantDemoTwo = "The \"use\" of quotations causes difficulties";
        Console.WriteLine("Demo 1 - {0}\Demo 2 - {1}", varianDemotOne , variantDemoTwo);
    }
}
