//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

using System;

class PlayWithIntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine(
@"Please choose a type:
1 --> int
2 --> double
3 --> string");

        int input = int.Parse(Console.ReadLine());
        int intInput = 0;
        double doubleInput = 0;
        string stringInput = "";

        switch (input)
        {
            case 1:
                Console.Write("Please enter an int: ");
                intInput = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", intInput + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", doubleInput + 1.0);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                stringInput = Console.ReadLine();
                Console.WriteLine("{0}*", stringInput);
                break;
            default:
                break;
        }
    }
}
