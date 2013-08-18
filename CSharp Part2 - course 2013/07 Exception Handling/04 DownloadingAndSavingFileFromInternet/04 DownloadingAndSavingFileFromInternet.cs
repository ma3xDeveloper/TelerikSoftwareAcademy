using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04_DownloadingAndSavingFileFromInternet

/*
04 Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
 Find in Google how to download files in C#.  Be sure to catch all exceptions and to free any used resources in the finally block
 
ОБЯСНЕНИЕ: Целта тук е да се запознаем с using System.Net неймспейса и същевременно да разучим ка работи WebClient-а към него, с чиято помощ може да се свлалят файлове от интернет.
 Когато пуснете кода и той се изпълни, файлът който ще се изтегли (в случая картинка на Дарт Вейдър) ще се запише по подразбиране във папката "...bin\Debug" на текущото приложение.
 И отново прихващам евентуалните грешки с try-catch блокове.
*/
{
    class Program
    {
        static void Main()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("http://upload.wikimedia.org/wikipedia/en/7/76/Darth_Vader.jpg", "vaderImageName.jpg"); // here we enter the web address to download the file
                    Console.WriteLine("The image has been successfully downloaded.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The address parameter must not be null!");
                }
                catch (WebException)
                {
                    Console.WriteLine("Error downloading file!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The method DownloadFile() cannot be called simultaneously on multiple threads.");
                }
                finally
                {
                    Console.WriteLine("Bye, and may the Force be with you!");
                }
            }
        }
    }
}