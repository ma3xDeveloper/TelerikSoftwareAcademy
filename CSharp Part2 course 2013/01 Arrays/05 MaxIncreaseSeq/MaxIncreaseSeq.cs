using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MaxIncreaseSeq
{
    class MaxIncreaseSeq
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. 

            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine("Enter {0} elements: ", length);
            for (int index = 0; index < length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            int maxSequence = 0;
            int sequence = 1;
            string sequenceNumbers = "";
            string maxSequenceNumbers = "";
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    sequence++;
                    sequenceNumbers += array[i] + " ";
                }
                else
                {
                    if (maxSequence < sequence)
                    {
                        maxSequence = sequence;
                        sequenceNumbers += array[i] + " ";
                        maxSequenceNumbers = sequenceNumbers;
                    }
                    sequence = 1;
                    sequenceNumbers = "";
                }
            }

            if (maxSequence < sequence)
            {
                sequenceNumbers += array[array.Length - 1];
                maxSequenceNumbers = sequenceNumbers;
            }

            Console.WriteLine("The maximal increasing sequence in an array is: ");
            Console.WriteLine(maxSequenceNumbers);
        }
    }
}

//ОБЯСНЕНИЕ: Създаваме си масив от някакви числа, които въвеждаме ръчно от конзолата. Създаваме си първоначално 4 променливи. 
//В maxSequence ще отброяваме броя на нарастващите последователности, ако може така да се каже. Примерно ако имаме поредица от числата 1,2,5,1 в тази променлива ще се запише 3.
//В sequence променливата ще записваме броя на моментните повторения, които цикълът е открил.
//В sequenceNumbers ще се записват самите числа, които в момента цикъла проверява.
//В maxSequenceNumbers ще се съдържа максималната, най-голямата последователност от нанрастващи числа, която е открита до момента.
//Пускаме един нормален for цикъл, с който да срявняваме числата в поредицата, като в зависимост от това дали числото е по-малко или по-голямо от следващото сравнявано в редицата се изпълнява едно от if условията.
//Когато програмата премине през скобите със самите if условия, "зачистваме"  sequence и sequenceNumbers променливите, съответно с числото 1 и "". След което останалато е лесно - програмата се връща отново горе във for цикъла,
//минава и сравнява останалите числа по редицата и накрая прогрмата принтира резултата