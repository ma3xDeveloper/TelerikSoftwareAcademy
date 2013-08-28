using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
02 Write a program that concatenates two text files into another text file.
 * 
ОБЯСНЕНИЕ: Четем първия файл, после втория подобно на предишната задача. Разликата тук е че ще трябва да забишем съдържанието им "конкатинирано" (слепено) едно след друго в отделен файл.
Със StreamWriter записваме и за първия и за втория файл, като важното тук на което трбява да обърнете внимание, е че StreamWriter има и конструктор, 
на който се задават два параметъра - пътят до файла и булева променлива, 
която определя дали да записва във новия файл като изтрие всичко записано в него домомента или да допълва (конкатинира) в него към вече съществуващото съдържание.
 */

namespace _02_ConcatenatesTwoTextFiles
{
    class ConcatenatesTwoTextFiles
    {
        static void Main()
        {
            StreamReader readerFirstFile = new StreamReader("demo1.txt");
            StreamReader readerSecondFile = new StreamReader("demo2.txt");

            using (readerFirstFile)
            {
                StreamWriter writer = new StreamWriter("demoSum.txt", false);

                using (writer)
                {
                    string s;
                    while ((s = readerFirstFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }
                }
            }

            using (readerSecondFile)
            {
                StreamWriter writer = new StreamWriter("demoSum.txt", true);

                using (writer)
                {
                    string s;

                    while ((s = readerSecondFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }
                }
            }
        }
    }
}