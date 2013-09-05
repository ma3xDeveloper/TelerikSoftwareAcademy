using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ParsesURL
{
    class ParsesURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL:");
            string url = Console.ReadLine();
            int index = url.IndexOf("://");
            string protocol = url.Substring(0, index);
            int index1 = url.IndexOf('/', index + 3);
            string server = url.Substring(index + 3, index1 - index - 3);
            string resource = url.Substring(index1);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
