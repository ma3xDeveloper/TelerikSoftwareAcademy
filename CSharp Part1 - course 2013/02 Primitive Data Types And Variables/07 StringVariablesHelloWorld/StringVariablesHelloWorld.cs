using System;

/*
7. Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

ОБЯСНЕНИЕ: Създаваме си две string променливи съдържащи в себеси съотвeтно стринговете "Hello" и "World". 
В задачата се иска да конкатенираме (залепим) двата стринга, като между тях трябва да има празно пространсто (добавя се чрез " ") и да се запише резултата в променлива от тип object.
След това трябва да запишем object променливата в променлива от тип string - това става като cast-нем object променливата (записваме в скоби (string) точно пред името на променливата concatenation).

 */

class StringVariablesHelloWorld
{
    static void Main()
    {
        string hellowStr = "Hello";
        string worldStr = "World";
        object concatenation = hellowStr + " " + worldStr;

        string result = (string)concatenation;

        Console.WriteLine(result);
    }
}
