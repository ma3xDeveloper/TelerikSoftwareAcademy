using System;

/*
4. Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.

ОБЯСНЕНИЕ: Цета тук е в int променлива да запишем числото 254, като за целта трябва да го запишем в шестнайсетичен формат. 
В плейсхолдъра {} на Console.WriteLine() слагаме ":x", което ще ни изпечата числото и в шестнайсетичен формат.

 */

class DeclareInHecadecimal
    {
        static void Main()
        {
            int number = 0xFE;
            Console.WriteLine("{0:x}", number);
        }
    }
