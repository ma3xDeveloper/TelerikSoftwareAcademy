using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
01 Write a program that reads a text file and prints on the console its odd lines.

ОБЯСНЕНИЕ: За да отпечатаме всички нечетни редове, които се намират в текстовия ни файл (в случая аз съм го кръстил "demo.txt", и съм го сложил в ...\bin\Debug папката)
ще използваме един обикновен while цикъл, който ще се изпълнява докато редът стане равен нa null - това, ще означава, 
че няма повече редове за четене и програмата ще освободи текстовия файл, автоматично излизайки от кода, намиращ се в тялото на using () конструкцията.
С помоща на if условието, в което делим на 2 - печатаме на конзолата само нечетните редове. 
*/

namespace _01_PrintsOddLines
{
    class PrintsOddLines
    {
        static void Main()
        {

         using (StreamReader sw = new StreamReader("demo.txt"))
            {
                int lineNumber = 1;
                string line = sw.ReadLine();

                while (line!=null)
                {
                    if (lineNumber%2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    lineNumber++;
                    line = sw.ReadLine();
                }
            } 
        }
    }
}   