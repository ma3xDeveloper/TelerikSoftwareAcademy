using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
07 Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB). 

ОБЯСНЕНИЕ: Четем съдържанието на demoStart.txt и с Replace() заменяме думите, записвайки ги в demoFinish.txt. След това с File.Delete трием demoStart.txt и с
помощта на File.Move го заменяме със съдържанието на demoFinish.txt и под ново име demoReplaces.txt.
*/

namespace _07_ReplaceStartWithFinish
{
    class ReplaceStartWithFinish
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("demoStart.txt"))
            {
                using (StreamWriter writer = new StreamWriter("demoFinish.txt"))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        string newLine = line.Replace("start", "finish");
                        writer.WriteLine(newLine);
                    }
                }
            }
            File.Delete("demoStart.txt");
            File.Move("demoFinish.txt", "demoReplaces.txt");
        }
    }
}
