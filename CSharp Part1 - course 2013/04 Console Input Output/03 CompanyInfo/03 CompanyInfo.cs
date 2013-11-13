using System;

class CompanyInfo

/*
03. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
Write a program that reads the information about a company and its manager and prints them on the console.


ОБЯСНЕНИЕ: Подобна задача имаше и в откриващата лекция от курса - просто четете информацията въведена в конзолата, записвате я в променливи и я принтирате на екрана после.

*/
{
    static void Main()
    {
        Console.WriteLine("Enter company's name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter company's address: ");
        string address = Console.ReadLine();

        Console.WriteLine("Enter company's phone: ");
        long phone = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter company's fax: ");
        long fax = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter company's website: ");
        string site = Console.ReadLine();
        
        Console.WriteLine("Enter Manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Enter Manager's last name: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Enter Manager's age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter Manager's phone number: ");
        long managerPhone = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Company name: {0}\nAddress: {1}\nPhone Number: {2}    fax: {3}\nWebsite: {4}\n", name, address, phone, fax, site);
        Console.WriteLine("Manager Information:\nName: {0} {1}\n Age: {2}\nPhone: {3}\n", managerFirstName, managerLastName, age, managerPhone);
    }
}
