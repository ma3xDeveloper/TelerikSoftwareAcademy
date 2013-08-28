using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
10 Write a program that extracts from given XML file all the text without the tags. Example:
 * <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>

ОБЯСНЕНИЕ: Тук трябва да екстрактнем текта, който се намира между скобите "> <". Четем файла ред по ред и търсим първия символ символ ">" и след него започваме да записваме
символите които намерим, и така, докато не намерим съответния затваращ символ "<". 
*/

namespace _10_ExtractsOnlyTextFromXML
{
    class ExtractsOnlyTextFromXML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("demoXML.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                string extract = "";
                while (line != null)
                {
                    for (int p = 1; p < line.Length; p++)
                    {
                        if (line[p - 1] == '>')
                        {
                            while (line[p] != '<')
                            {
                                extract += line[p];
                                p++;
                            }
                            if (extract != "")
                            {
                                Console.WriteLine(extract);
                                extract = "";
                            }
                        }
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}