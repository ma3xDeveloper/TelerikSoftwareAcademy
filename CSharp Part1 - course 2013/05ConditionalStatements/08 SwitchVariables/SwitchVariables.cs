using System;

/* 
 
08. Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, 
increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

 ОБЯСНЕНИЕ: За да решим задачата са ни необходими 3 случая за изпълнение, в зависимост от това, какво е въвел потребителят (int число, double или string). Ще изпозлваме switch конструкцията, така както се изисква по условие.
 Създаваме трите случая и прилежащите условия към всяко едно от тях - добавянето на числото 1 или символът "*". Приканваме потребителя още в началото да си избере към кой от трите случая да се насочи, като за целта трябва да въведе или 1, или 2, или 3.
 В зависимост от това се задейства един от трите случая в switch-а и се изпечатва на конзолата.
 
 */

class SwitchVariables
{
    static void Main()
    {
        Console.WriteLine("Please choose:\n1- for Int Variable\n2- for Double Variable\n3- for String Variable\n... and then enter some variable.");
        int choose = int.Parse(Console.ReadLine());

        switch (choose)
        {
            case 1:
                int number = int.Parse(Console.ReadLine());
                number++;
                Console.WriteLine("{0}", number);
                break;

            case 2:
                double number2 = double.Parse(Console.ReadLine());
                number2++;
                Console.WriteLine("{0}", number2);
                break;

            case 3:
                string str = Console.ReadLine();
                Console.WriteLine("{0}*", str);
                break;

            default: Console.WriteLine("Wrong Choice");
                break;
        }
    }
}
