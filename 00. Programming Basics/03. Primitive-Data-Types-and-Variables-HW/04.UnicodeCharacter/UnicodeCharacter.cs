//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be “*”.

using System;

class UnicodeChar
{
    static void Main()
    {

        char CharSymbol = '\u002A';

        Console.WriteLine("The code u002A is for the Symbol: {0}", CharSymbol);

    }
}