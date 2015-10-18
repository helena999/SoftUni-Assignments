//Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them. Today he is going on an expedition to collect all kind of diamonds, no matter small or large. Help your friend to find all the diamonds in the biggest known cave "The Console Cave". At the only input line you will be given the width of the diamond. The char that forms the outline of the diamonds is '*' and the surrounding parts are made of '-' (see the examples). Your task is to print a diamond of given size n.

using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));

        for (int i = 1; i <= n - 2; i += 2)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', (n - i - 2) / 2), new string('-', i));
        }
        for (int i = n - 4; i > 0; i -= 2)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', (n - i - 2) / 2), new string('-', i));
        }

        Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
    }
}