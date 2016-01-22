//SoftUni has opened a new training center in Kaspichan, but the people there did not know how to find it. Your task is to print a vertical arrow, which will be used to indicate the path to the new building in the city. This will help thousands of people to become software engineers. Please help them!

using System;

class Arrow
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int w = (n * 2) - 1; //width
        int h = w - (2 * (n / 2)) - 2; //height

        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', w - (2 * (n / 2))));

        for (int i = 1; i <= h; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', h));
        }

        Console.WriteLine("{0}{1}{0}", new string('#', (n / 2) + 1), new string('.', h));

        int temp = w - 4;
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', temp));
            temp = temp - 2;
        }

        Console.WriteLine("{0}#{0}", new string('.', n - 1), n);

    }
}
