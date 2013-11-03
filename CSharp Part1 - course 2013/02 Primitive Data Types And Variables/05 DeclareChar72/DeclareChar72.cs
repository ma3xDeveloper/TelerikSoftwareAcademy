using System;

/*
5. Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

ОБЯСНЕНИЕ: Целта тук е да се запознаем с ASCII таблицата - http://www.ascii-code.com/. За целта трябва да присвоим към една char променлива символа от таблицата, който има десетично представяне 72. Това е символът "H".
Ако прехвърлим 72 в шестнайсетична бройна система ще получим 48. Което отново потвърждава, че търсения символ е "H"

 */

class DeclareChar72
{
    static void Main()
    {
        char variableChar = '\u0048';
        Console.WriteLine(variableChar);
    }
}