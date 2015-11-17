//Little Joro likes to build huts. After he built all the huts in his whole village, he decided to go to the big city and start building houses. But his knowledge of how to do this is limited. Help Joro to design the facade of a beautiful house by printing it to the console. The house must have a roof and one floor. The roof must contains only the symbols ‘*’ and ‘-’ and the floor must contains the symbols ‘*’ and ‘|’ 

using System;

class NewHouse
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // height of the hut without the roof

        for (int i = 1; i <= n ; i+=2)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', (n-i)/2), new string('*', i));
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('|', 1), new string('*', n-2));
        }
    }
}
