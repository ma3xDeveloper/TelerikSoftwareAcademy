using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSMTest
    {
        // Task 07 - the GSM Test

        public GSMTest()
        {
            GSM[] gsmArr = new GSM[5];
            string[] models = { "HTC", "Samsung", "LG", "Nokia", "KucheMobile" };
            int[] prices = { 120, 340, 505, 620, 1100 };
            string[] owners = { "Messi", "Ronaldo", "Berbatov", "Skartel", "Hulk" };
            string[] manifacturers = { "China", "USA", "Japan", "France", "UK" };

            for (int i = 0; i < gsmArr.Length; i++)
            {
                gsmArr[i] = new GSM(models[i], manifacturers[i], prices[i], owners[i]);
                Console.WriteLine("Print with the overrided To String() method:");
                Console.WriteLine(gsmArr[i]);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S.Model);

            Console.WriteLine(GSM.IPhone4S.Manufacturer);
        }
    }
}
