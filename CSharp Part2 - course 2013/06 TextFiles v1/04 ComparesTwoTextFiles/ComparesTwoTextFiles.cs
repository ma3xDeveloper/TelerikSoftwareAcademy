using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
04 Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. 
Assume the files have equal number of lines.

ОБЯСНЕНИЕ: Задача, в която трябва да прочетете два текстови файла с еднакъв брой редове и да сравните редовете им един по един, като след това на конзолата трябва да се изпечатат, 
 номерата на редовете, които съвпадат и са абсолютно еднакви (обърнете внимание, че става дума за самите номера на еднаквите редове, а не за броя им), и номерата на редовете, които се различават. 
 Значителлно ще си олесните писането на решението на тази задача, чисто и просто като използвате метода Equals, който връща true, ако двата символни низа са еднакви. Сравняваме редовете един по един и в зависимост от това дали те са еднакви или се различават,
 ги записваме съответно в листовете sameLines и differentLines. След това печатаме тези листове с номерата на редовете на конзолата.
 */

namespace _04_ComparesTwoTextFiles
{
    class ComparesTwoTextFiles
    {
        static void Main()
        {
            StreamReader readerOneTxt = new StreamReader("quotesOne.txt");
            StreamReader readerTwoTxt = new StreamReader("quotesTwo.txt");

            using (readerOneTxt)
            {
                using (readerTwoTxt)
                {
                    string LineTextOne = readerOneTxt.ReadLine();
                    string LineTextTwo = readerTwoTxt.ReadLine();
                    List<int> sameLines = new List<int>();
                    List<int> differentLines = new List<int>();
                    int count = 1;

                    while (LineTextOne != null)
                    {
                        if (LineTextOne.Equals(LineTextTwo))
                        {
                            sameLines.Add(count);
                        }
                        else
                        {
                            differentLines.Add(count);
                        }
                        count++;
                        LineTextOne = readerOneTxt.ReadLine();
                        LineTextTwo = readerTwoTxt.ReadLine();
                    }

                    Console.WriteLine("Number of lines with same content are: {0}", string.Join(" ", sameLines));
                    Console.WriteLine("Number of lines with different content are: {0}", string.Join(" ", differentLines));
                }
            }
        }
    }
}