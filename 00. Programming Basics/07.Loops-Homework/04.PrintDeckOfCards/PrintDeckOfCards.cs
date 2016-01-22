using System;

class PrintDeckOfCards
{
    static void Main(string[] args)
    {
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';

        for (int i = 2; i <= 5 ; i++)
        {
            for (int j = 2; j <= 14; j++)
            {
                switch (j)
                {
                    case 2:
                        Console.Write("2");
                        break;
                    case 3:
                        Console.Write("3");
                        break;
                    case 4:
                        Console.Write("4");
                        break;
                    case 5:
                        Console.Write("5");
                        break;
                    case 6:
                        Console.Write("6");
                        break;
                    case 7:
                        Console.Write("7");
                        break;
                    case 8:
                        Console.Write("8");
                        break;
                    case 9:
                        Console.Write("9");
                        break;
                    case 10:
                        Console.Write("10");
                        break;
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                    default:
                        break;
                }

                switch (i)
                {
                    case 2:
                        Console.Write("{0} ",clubs);
                        break;
                    case 3:
                        Console.Write("{0} ", diamonds);
                        break;
                    case 4:
                        Console.Write("{0} ", hearts);
                        break;
                    case 5:
                        Console.Write("{0} ",spades);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}