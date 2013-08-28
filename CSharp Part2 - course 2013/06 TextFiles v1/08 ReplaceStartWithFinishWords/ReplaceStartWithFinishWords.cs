using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
08 Modify the solution of the previous problem to replace only whole words (not substrings).

ОБЯСНЕНИЕ: Идеята тук е да заменим всяка самостоятелна, отделна дума start с finish. Търсим думата start, така че около нея да няма други символи и я заместваме с finish. 
*/

namespace _08_ReplaceStartWithFinishWords
{
    class ReplaceStartWithFinishWords
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("demoStart.txt"))
            {
                using (StreamWriter write = new StreamWriter("demoFinish.txt"))
                {
                    for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                    {
                        for (int index = line.IndexOf("start"); index != -1; index = line.IndexOf("start", index + 1))
                        {
                            if ((index - 1 < 0 || !Char.IsLetter(line[index - 1])) && (index + 5 >= line.Length || !Char.IsLetter(line[index + 5])))
                            {
                                line = line.Insert(index, "finish").Remove(index + 6, 5);
                            }
                        }
                        write.WriteLine(line);
                    }
                }
            }
        }
    }
}