using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _03_FullFilePathAndReadAllText

 /*
03 Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
  reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
  Be sure to catch all possible exceptions and print user-friendly error messages.

ОБЯСНЕНИЕ: Целта на тази задача е да се запознаем с File.ReadAllText - http://msdn.microsoft.com/en-us/library/ms143368.aspx
Неговата работа (както името му подсказва) е да вземе един файл и да прочете целия текст от него и след това да затвори файла. За да можем да го използваме трябва да активираме предвидения за това namespace using System.IO, чието подробно обяснение е в лекцията за обработка на Текстови файлове.
В тази задача се изисква от вас и, така малко като в добрите стари DOS времена, лично вие сами да си въведете пътя до някой файл на вашия HDD, който ReadAllText да прочете.
Ако сбъркате - try-catch блока ще ви прихване грешката и ще ви каже къде бъркате.
*/
{
    class FullFilePathAndReadAllText
    {
        static void Main()
        {
            Console.Write("Type here \"frodo.txt\" to see the homework demo. \nIf you want to read another file in your PC type here the full file path and name:");

            try
            {
                Console.WriteLine(File.ReadAllText(Console.ReadLine()));
            }
            catch (Exception er)
            {
                Console.WriteLine("Error!\n{0}:{1}", er.GetType().Name, er.Message);
            }
        }
    }
}