//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main(string[] args)
    {
        Console.Write("Company name: ");
        string cName = Console.ReadLine();

        Console.Write("Company address: ");
        string cAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string pNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string fNumber = Console.ReadLine();
        if (fNumber == String.Empty)
        {
            fNumber = "(no fax)";
        }

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string mFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string mLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        string mAge = Console.ReadLine();

        Console.Write("Manager phone: ");
        string mPhone = Console.ReadLine();

        string newL = "\n";

        Console.WriteLine();

        string companyInformation = "{0}{1}Address: {2}{1}Tel. {3}{1}Fax: {4}{1}Web site: {5}{1}Manager: {6} {7} (age:{1}{8}, tel.{9})";

        Console.WriteLine(companyInformation, cName, newL, cAddress, pNumber, fNumber, webSite, mFirstName, mLastName, mAge, mPhone);


    }
}
