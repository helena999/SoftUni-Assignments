//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


using System;

class employeeData
{
    static void Main()
    {
        string FirstName = "Petar";
        string LastName = "Petrov";
        byte Age = 24;
        char GenderMale = 'm';
        ulong IDnumber = 8306112507;
        uint UniqueEmployeeNumber = 27569990;

        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Gender: {0}", GenderMale);
        Console.WriteLine("ID Number: {0}", IDnumber);
        Console.WriteLine("Unique Employee Number: {0}", UniqueEmployeeNumber);
    }
}

