using System;
using System.Text;

/*
9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. 
   Note: the © symbol may be displayed incorrectly.

ОБЯСНЕНИЕ: Тук трябва да нарисуваме на конзолата триъгълник, състоящ се от 9 copyright символа -  ©. За целта трябва да намерим в Unicode таблицата кода на този символ, който в случая е A9 в шестнайсетичен формат (изписваме го така - "\u00A9").
Белжката "the © symbol may be displayed incorrectly" ни е дадена, защото copyright символа може да не се изпечата коректно на конзоата ни, заради различните регионални езикови настройки, които сме задали на нашата ОС.
За да избегнем този проблем активираме namespace-а using System.Text и използваме методът OutputEncoding на конзолата, чрез който й задаваме да печата с желаните от нас енкодинг настройки.
 */

namespace CopyrightSymbols
{
    class CopyrightSymbols
    {
        static void Main()
        {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("  \u00A9");
        Console.WriteLine(" \u00A9\u00A9\u00A9");
        Console.WriteLine("\u00A9\u00A9\u00A9\u00A9\u00A9");
        }
    }
}