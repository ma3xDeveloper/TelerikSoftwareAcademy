//Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PrintHello
{
    class PrintHello
    {
        static void SayHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter your name");
            SayHello(Console.ReadLine());
        }
    }
}

//ОБЯСНЕНИЕ: Лесна задача, като за първа :) Правим си съвсем прост метод.