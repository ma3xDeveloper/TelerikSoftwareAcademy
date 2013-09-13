using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

//ОБЯСНЕНИЕ: Доста лесна задача, на фона на останалите досега :) Имаме си масив от стрингове, който трябва да сортираме според дължината на елементите им.
//Сортираме си масива с Array.Sort метода, към който прикрепяме една ламбда функция като тази от лекцията за Многомерни масиви. След това печатаме резултата.

namespace _05_ArrayStringsSortsByLength
{
    class ArrayStringsSortsByLength
    {
        static void Main()
        {

            string[] array = { "Messi", "RobinVanPersie", "Berbatov", "Isko", "HristoStoichkov" };

            Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}

