using System;

class CalculateSumWithAccuracy

/*
10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

ОБЯСНЕНИЕ: Тук вместо int ще използваме decimal. Настройваме for цикъла да проверява дали операцията която ще се извършва е за четно или нечетно число и съответно той извърта операциите по уравнението до 100.
Когато е готов с изчисленията и е сумирал резултата в конзолата използваме {0:0.000} форматиране на плейсхолдъра, където ще се намести резултата от променливата, която държи в себе си сумата.

*/

{
    static void Main()
    {
        decimal sum = 0M;

        for (decimal i = 1M; i <= 100; i++)
        {
            checked
            {
                if (i % 2 == 0)
                {
                    sum = (1 / i) + sum;
                }
                else
                {
                    sum = (1 / i) - sum;
                }
            }
        }

        Console.WriteLine("The result of calculating the \"1+1/2-1/3+1/4-1/5+...+1/100\" is: {0:0.000}", sum);
    }
}
