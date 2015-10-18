//Joro loves a lot to play football. He used to play for his local village club “Pantera” Kaloyanovets. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Joro plays in 1/2 of the holidays and once in the weekends, but not every weekend – only when he is not tired and only when he is not going to his hometown. Joro goes at his hometown h weekends in the year. The other weekends are considered “normal”. Joro is tired in 1/3 of the normal weekends. When Joro is at his hometown, he always plays football with his old friends once, at Sunday. In addition, if the year is leap, Joro plays football 3 more times additionally, in non-weekend days. We assume the year has exactly 52 weekends.
//Your task is to write a program that calculates how many times Joro plays football (rounded down to the nearest integer number).

using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        Console.WriteLine("How many times Joro plays football in the year?\n");
        Console.WriteLine("Is this year leap or not? (Write \"t\" for true and \"f\" for false)");


        string t = Console.ReadLine();

        Console.WriteLine("\nWrite the number of holidays in the year which are not Saturday or Sunday: ");
        short p = short.Parse(Console.ReadLine());


        Console.WriteLine("\nHow many weekends Joro spends in his hometown?");
        byte h = byte.Parse(Console.ReadLine());

        double TotalWeekends = 52;
        double playsInHoliday = 0.5 * p;
        double playsinHometown = h;
        double normalWeekends = TotalWeekends - h;
        double normalWeekendsPlay = normalWeekends * 2 / 3;

        double totalPlays = playsInHoliday + playsinHometown + normalWeekendsPlay;

        if (t == "t")
        {
            totalPlays = totalPlays + 3;
            totalPlays = Math.Floor(totalPlays);
            Console.WriteLine("\nTotal plays: {0}", totalPlays);
        }
        else
        {
            totalPlays = Math.Floor(totalPlays);
            Console.WriteLine("\nTotal plays: {0}", totalPlays);
        }
    }
}

