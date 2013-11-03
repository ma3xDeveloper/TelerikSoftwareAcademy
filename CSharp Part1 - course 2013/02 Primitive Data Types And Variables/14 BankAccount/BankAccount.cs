using System;

/*
14. A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 * 
ОБЯСНЕНИЕ: Задача аналогична на 10-та, в която трябва да подберем правилните променливи

 */

class BankAccount
{
    static void Main()
    {
        string firstName = "";
        string middleName = "";
        string lastName = "";
        decimal MoneyBalance = new decimal();
        string bankName = "";
        object iBanCode = new object(); //IBAN се състои от букви и цифри
        object bicCode = new object(); //BIC се състои от букви и цифри
        long creditCardNumberOne = new long();
        long creditCardNumberTwo = new long();
        long creditCardNummberThree = new long();
    }
}
