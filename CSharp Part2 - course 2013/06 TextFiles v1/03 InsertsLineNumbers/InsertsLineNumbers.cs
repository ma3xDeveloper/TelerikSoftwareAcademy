using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
03 Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

ОБЯСНЕНИЕ: Тук това, на което трябва да обърнете внимание, е че за да отпечатваме текст преди всеки ред, който да ни казва на кой точно ред сме,
трябва да си направим променлива (count), която да пази информацията, за това на кой точно ред сме и чрез нея да изписваме номера на реда ("Line: "), преди да изпишем самия ред.
*/

namespace _03_InsertsLineNumbers
{
    class InsertsLineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("demoLines.txt");

            using (reader)
            {
                int count = 1;
                string line;
                StreamWriter writer = new StreamWriter("demoResult.txt", false);

                using (writer)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.Write("Line {0}: ", count);
                        writer.WriteLine(line);
                        count++;
                    }
                }
            }
        }
    }
}