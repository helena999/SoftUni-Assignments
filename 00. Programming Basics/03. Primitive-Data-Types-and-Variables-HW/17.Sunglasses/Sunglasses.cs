//The input data should be read from the console.You have an integer number N (always an odd number) specifying the height of sunglasses.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//The output should be printed on the console.
//You should print the sunglasses on the console. The sunglasses consist of three parts: frames, lenses and a bridge (the connection between the two frames). Each frame's width is double the height N and should be printed using the character '*' (asterisk). Print the lenses with the character '/'. Finally, connect the two frames with a bridge that is of size N, using the character '|'. Leave the rest of the space between the frames blank.

using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // n = height
        int width = 2 * n;

        string frame = new string('*', width);
        string spaces = new string(' ', n);
        string lens = new string('/', width - 2);
        string bridge = new string('|', n);
        string lensAndFrame = String.Format("{0}{1}{0}", '*', lens);

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.WriteLine(frame + spaces + frame); //Print first and last row of the frame
            }
            else if (i == n / 2) //Print midlle frame row + bridge. Za da namerim sredata, celochisleno delene
            {
                Console.WriteLine("{0}{1}{0}", lensAndFrame, bridge);
            }
            else //Print all other rows of the frame
            {
                Console.WriteLine("{0}{1}{0}", lensAndFrame, spaces);
            }
        }
    }
}