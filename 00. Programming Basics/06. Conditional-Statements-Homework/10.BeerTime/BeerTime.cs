//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 

using System;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        DateTime time = DateTime.Parse(input);
        int hour = int.Parse(time.ToString("hh"));
        int min = int.Parse(time.ToString("mm"));
        string amPm = time.ToString("tt", CultureInfo.InvariantCulture);
      
        switch (amPm)
        {
            case "AM":
                if (hour <= 12 && hour >= 4)
                {
                    Console.WriteLine("non-beer time");   
                }
                else if (hour >= 1 && hour <= 3)
                {
                    Console.WriteLine("beer time");
                }
                break;
            case "PM":
                if (hour >= 1 && hour <= 12)
                {
                    Console.WriteLine("beer time");
                }
                break;
            default:
                break;
        }        
    }
}
