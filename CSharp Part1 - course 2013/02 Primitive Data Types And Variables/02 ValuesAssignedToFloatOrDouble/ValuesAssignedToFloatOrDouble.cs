using System;

/*
2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

ОБЯСНЕНИЕ: Тук гледаме броя на цифрите след десетичната запетая и така опредеяме типа променлива. Както знаем float помни с точност до 7 цифри, а double до 15-16 цифри.

 */

class ValuesAssignedToFloatOrDouble
{
    static void Main()
    {
       double numberOne = 34.567839023;
       float numberTwo = 12.345f;
       double numberThree = 8923.1234857;
       float numberFour = 3456.091f;
    }
}
