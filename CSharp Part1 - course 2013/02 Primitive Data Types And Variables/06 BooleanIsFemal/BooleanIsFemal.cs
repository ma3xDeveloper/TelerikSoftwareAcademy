using System;

/*
6. Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

ОБЯСНЕНИЕ: Целта тук е да се запознаем с булевите променливи. Те имат само и единствено две възможни стойности - true или false. 
Създаваме си булева променлива isFamel, която ще запише отговорът на въпроса дали потребителят е мъж или жена. Четем от конзолата  "male" или "female" и записваме в стринг с име myGender.
Използвам if-else конструкция, чрез която, ако (if) потребителят е въвел "female", то тогава към булевата променлива isFamel пристоявам стояността true. 
В противен случай (else), ако не го е направил, значи е въвел "male" и съответно isFamel трябва да приеме другата възможна булева стойност - false. 

 */

class BooleanIsFemal
{
    static void Main()
    {
        bool isFamel;
        Console.WriteLine("What is your gender (type \"male\" or \"female\"): ");
        string myGender = Console.ReadLine();

        if (myGender == "female")
        {
            isFamel = true;
        }
        else
        {
            isFamel = false;
        }
        Console.WriteLine("Are you female: " + isFamel);
    }   
}
