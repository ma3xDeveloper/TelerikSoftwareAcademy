using System;

/*
07 Create a console application that prints the current date and time.

ОБЯСНЕНИЕ: Тук вече трябва да изпишем моментната дата и час, която се показва на компютъра. Това става като използваме DateTime.Now. 
Повече инфо какво прави DateTime тук - http://msdn.microsoft.com/query/dev11.query?appId=Dev11IDEF1&l=EN-US&k=k(System.DateTime);k(DateTime);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5);k(DevLang-csharp)&rd=true
*/

class PrintCurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);
    }
}
