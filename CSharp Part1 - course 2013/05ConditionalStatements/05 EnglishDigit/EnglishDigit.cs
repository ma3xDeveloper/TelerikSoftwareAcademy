using System;

/* 
 
05. Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
 
ОБЯСНЕНИЕ: Проста задача, която цели да ни запознае с най-основната функция на switch условния конструктор, която подробно е обяснена из слайдовете на лекцията към курса. 
Накратко - четем от конзолата число и то минава по 9-те случая на на switch-а в търсене на правилните букви, с които да се изпише това число на конзолата.
 
 */

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please enter a digit: ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero"); break;

            case 1:
                Console.WriteLine("One"); break;

            case 2:
                Console.WriteLine("Two"); break;

            case 3:
                Console.WriteLine("Three"); break;

            case 4:
                Console.WriteLine("Four"); break;

            case 5:
                Console.WriteLine("Five"); break;

            case 6:
                Console.WriteLine("Six"); break;

            case 7:
                Console.WriteLine("Seven"); break;

            case 8:
                Console.WriteLine("Eight"); break;

            case 9:
                Console.WriteLine("Nine"); break;

            default: Console.WriteLine("\nEnter a digit betwean 0 and 9\n");
                break;
        }
    }
}
