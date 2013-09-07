using System;

class ArrayOf20IntsMultipliedBy5
{
    static void Main()
    {
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

        int[] myArr = new int[20];

        for (int i = 0; i < myArr.Length; i++)
        {
            myArr[i] = i * 5;
        }

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine(myArr[i]);
        }
    }
}

//ОПИСАНИЕ: Инициализираме масив от 20 елемента. С for цикъл обхождаме елементите му всеки един от които го умножаваме по 5.
//След това с втория for цикъл принтираме резултата на конзолата.