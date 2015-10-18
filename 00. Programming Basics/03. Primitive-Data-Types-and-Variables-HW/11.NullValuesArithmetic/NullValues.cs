//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? A = null;
        Console.WriteLine("This is the Null value in this integer variable -> " + A);
        A = 5;
        Console.WriteLine("This is the value in this integer variable -> " + A);


        double? B = null;
        Console.WriteLine("This is the value in this double variable -> " + B);
    }
}

