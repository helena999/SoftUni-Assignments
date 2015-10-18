//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter weight of the person on the Earth:");
        double aPersonWeight = double.Parse(Console.ReadLine());
        double gravitationOnTheMoon = 0.17;

        double moonWeight = (aPersonWeight * gravitationOnTheMoon);
        Console.WriteLine("The person's weight on the Moon is: {0}", moonWeight);
    }
}