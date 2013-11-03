using System;

/*
1. Declare five variables choosing for each of them the most appropriate of 
the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

ОБЯСНЕНИЕ: Целта на задачата е да подберете правилните променливи, който са най-подходящи за съответните стойности. Например 97 е число, което няма смисл да бъде записвано в ulong примерно.

 */

class DeclareVariables
{
    static void Main()
    {
        ushort numberOne = 52130;
        sbyte numberTwo = -115;
        int numberThree = 4825932;
        sbyte numberFour = 97;
        short numberFive = -10000;
    }
}