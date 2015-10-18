//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).

using System;


class PrintASCIITable
{
    static void Main()
    {
        Console.Write("Decimal Code");
        Console.Write("Hexadecimal Code".PadLeft(20));
        Console.WriteLine("ASCII code".PadLeft(20));
        string dashLine = "".PadLeft(52, '-'); //Repeats 40 times the character '-'
        Console.WriteLine(dashLine);

        for (int i = 0; i <= 255; i++)
        {
            
            if (i >=100)
            {
                Console.Write("{0:00}".PadLeft(9), i);
                Console.Write("{0}", i.ToString("X4").PadLeft(20));
                Console.WriteLine("{0}".PadLeft(25), (char)i);
            }
            else
            {
                Console.Write("{0:00}".PadLeft(10), i);
                Console.Write("{0}", i.ToString("X4").PadLeft(20));
                Console.WriteLine("{0}".PadLeft(25), (char)i);
            }

        }
    }
}