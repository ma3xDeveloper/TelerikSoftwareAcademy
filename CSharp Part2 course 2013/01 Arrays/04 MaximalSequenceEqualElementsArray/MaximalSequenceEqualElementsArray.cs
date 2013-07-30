using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSequenceEqualElementsArray
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.

        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        Console.WriteLine("Enter {0} elements: ", length);
        for (int index = 0; index < length; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        int longestSequence = 0;
        int value = 0;
        for (int index = 0; index < length - 1; index++)
        {
            if (arr[index] == arr[index + 1])
            {
                counter++;
                if (longestSequence < counter)
                {
                    longestSequence = counter;
                    value = arr[index];
                }
            }
            else
            {
                counter = 0;
            }
        }
        if (longestSequence == 0)
        {
            Console.WriteLine("There is no sequence of elements");
        }
        else
        {
            Console.WriteLine("The longest sequence is of {0} elements", longestSequence + 1);
        }
    }
}

//ОБЯСНЕНИЕ: Заделяме масив и го инициализираме. Създаваме три нови променливи: counter, longestSequence и value. 
//В първата ще записваме текущото проверявано повторение от числа, във втората ще записваме най-гоямото повтореине от числа и в последната (value) ще запишем елемента, който съзава най-дългата поредица.
//С for цикъла сравняваме числата позиция по позиция. Ако намерим две еднакви се изпълнява if условието, в което са събрани трите променливи.
//Накрая яко longestSequence е различно от 0 т.е. ако сме открили някаква повтаряща се поредица, изписваме колко е голяма тя на конзолата.