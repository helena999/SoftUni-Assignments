//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string FirstName = "Petar";
        string MiddleName = "Jivkov";
        string LastName = "Petrov";
        string Space = " ";
        Console.WriteLine("Names of the client: {0} {1} {2}", FirstName, MiddleName, LastName);

        double Balance = 10431.50D;
        string Currency = "лева";
        Console.WriteLine("Balance of account: {0} {1}", Balance, Currency);

        string BankName = "Sosiete Generale Експресбанк";
        Console.WriteLine("Bank Name: {0}", BankName);

        string IBAN = "BG23SASD12544588765432";
        Console.WriteLine("IBAN: {0}", IBAN);

        ulong FirstCreditCardNumber = 12321232123212456;
        ulong SecondCreditCardNumber = 98765456735342678;
        ulong ThirdCreditCardNumber = 943843376546879929;
        Console.WriteLine(@"First Credit Card Number:  {0}
Second Credit Card Number: {1}
Third Credit Card Number:  {2}", FirstCreditCardNumber, SecondCreditCardNumber, ThirdCreditCardNumber);



    }
}

