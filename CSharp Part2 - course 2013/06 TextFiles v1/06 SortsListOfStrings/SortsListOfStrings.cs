using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
06 Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

ОБЯСНЕНИЕ: Идеята е да прочетем имената от един текстов файл, да ги сортираме по някакъв произволен начин (лично аз използвах просто метода Sort() ) 
 и след това вече сортираните имена да ги запишем в отделен текстов файл. Просто четем съдържанието на първия файл със StreamReader. След това с един обикновен for цикъл записваме в един List
 самите имена. Сортираме ги. И след това със StreamWriter и един foreach цикъл си ги записваме в един нов текстов файл.
*/

namespace _06_SortsListOfStrings
{
    class SortsListOfStrings
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("unsortedNamesLOTR.txt"))
            {
                List<string> names = new List<string>();

                for (string currentNameTxt = reader.ReadLine(); currentNameTxt != null; currentNameTxt = reader.ReadLine())
                {
                    names.Add(currentNameTxt);
                }

                names.Sort();

                using (StreamWriter writer = new StreamWriter("sortedNamesLOTR.txt"))
                {
                    foreach (string name in names) writer.WriteLine(name);
                }
            }
        }
    }
}