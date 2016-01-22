//Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have to help him construct the building from the ground zero.
//The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls and the base of the house it build of '*'. Everything else is filled with '.' (see the examples below to catch the idea).
//You will be given an odd integer N, representing the width and the height of the house. The roof’s top starts from the center (N+1)/2 and forms a triangle with base of width N. The roof’s height is (N+1)/2. The distance between the roofs’ end point and the walls of the building is N/4, rounded down to an integer number. See the examples below to understand better these formulas.


using System;

class House
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', ((n-1) / 2)));

        //The roof
        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (n / 2) - i), new string('.', n - 2 - (2*((n/2)-i))));
        }
        Console.WriteLine(new string('*', n));

        //The base
        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (n / 4)), new string('.', (n -2)- 2 * (n / 4)));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - 2 * (n / 4)));
    }
}
