using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwoArraysComparesElement
{
    static void Main()
    {
        //Write a program that reads two arrays from the console and compares them element by element

        Console.WriteLine("Pleas enter the lenght of the FIRST Array:");
        int f = int.Parse(Console.ReadLine());
        int[] firstArr = new int[f];

        Console.WriteLine("Pleas enter the lenght of the SECOND Array:");
        int s = int.Parse(Console.ReadLine());
        int[] secondArr = new int[s];

        if (firstArr.Length != secondArr.Length)
        {
            Console.WriteLine("Error! The FIRST Array lenght and the SECOND Array lenght are not equal. Please try again and enter EQUAL array lenghts");
        }

        for (int i = 0; i <= firstArr.Length - 1; i++)
        {
            Console.WriteLine("Please enter the {0} number of FIRST array", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= secondArr.Length - 1; i++)
        {
            Console.WriteLine("Please enter the {0} number of SECOND array", i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        for (int i = 0; i < secondArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    }
}

//ОБЯСНЕНИЕ: Първото нещо, което правим е да инициализираме самия размер на двата масива. 
//Макар и незадължително по условие, с помоща на if условието проверяваме дали броя на елементите в двата масива са равни. 
//Това може и да не го правим, ако просто накараме потребителя веднъж да въведе число за размера на масивите (веднъж като го въведе ще го ползваме същата променлива при инициализацията и на втория масив).
//След това с помощта на for цикли въвеждаме самите стойности из одтелните позиции на двата масива.
//Преминаваме към същинската част на задачата - сравняване на самите отделни стойности в масива една по една. Използваме булева променлива, в която изначално казваме че елементите в двата масива са равни, до доказване на противното.
//С помощта на for цикъл започваме да сравняваме отделните елементи на масивите един по един. 
//В случай че два елемента от една и съща позиция в масивите се случи да не са равни се изпълнява if условието, променливата, която съзадохе по-горе вече става false и се прехвърляме към break оператъра, тъй като при това положение няма смисъл да продължаваме да сравняваме останалите елементи из масивите.
//Отпечатваме резолтата на конзолата.