using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
09 Write a program that deletes from given text file all odd lines. The result should be in the same file.

ОБЯСНЕНИЕ: Създаваме си променлива fileName, чиято стойност е името на файла, с който ще работим. Подаваме го на метода FileEdit, чрез който
прочитаме съдържанието на файла ред по ред и в отделен лист (fileLines) записваме всички четни редове. След тази опреция using блока затваря автоматично използваните ресурси за четене от файла.
Следващия поток, който отваряме към файла е за писане, използвайки листа, в който са записани всички четни редове, ние презаписваме съдържанието на текстовия файл с тях.
*/

namespace _09_DeleteOddLines
{
    class DeleteOddLines
    {
        private static void FileEdit(string fileName)
        {
            List<string> fileLines = new List<string>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        fileLines.Add(line);
                    }
                    line = readFile.ReadLine();
                    lineNumber++;
                }
            }

            using (StreamWriter rewriteFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < fileLines.Count; i++)
                {
                    rewriteFile.WriteLine(fileLines[i]);
                }
            }
        }

        static void Main()
        {
            string fileName = "demoLines.txt";
            FileEdit(fileName);
        }  
    }
}