//Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Vladi plays in 2/3 of the holidays and each Saturday, but not every weekend – only when he is not at work and only when he is not going to his hometown. Vladi goes at his hometown h weekends in the year. The other weekends are considered “normal”. Vladi is not at work in 3/4 of the normal weekends. When Vladi is at his hometown, he always plays volleyball with his old friends once, at Sunday. In addition, if the year is leap, Vladi plays volleyball 15% more times additionally. We assume the year has exactly 48 weekends suitable for volleyball.
//Your task is to write a program that calculates how many times Vladi plays volleyball (rounded down to the nearest integer number).


using System;

class Voleyball
{
    static void Main()
    {
        string leapOrNormal = Console.ReadLine();
        double p = int.Parse(Console.ReadLine()); //number of holidays 
        double h = int.Parse(Console.ReadLine()); //number of weekends in his hometown

        double playsInHolidays = (p * (2.0 / 3.0));
        double playsInHometown = h;
        double normalWeekends = 48 - h;
        double playsNormalWeekends = normalWeekends * (3.0 / 4.0);
        double totalPlays = playsInHolidays + playsInHometown + playsNormalWeekends;

        if (leapOrNormal == "leap")
        {
            double leapYear = totalPlays * 0.15;
            totalPlays = totalPlays + leapYear;
            ;
            Console.WriteLine(Math.Floor(totalPlays));

        }
        else
        {
            Console.WriteLine(Math.Floor(totalPlays));
        }
    }
}