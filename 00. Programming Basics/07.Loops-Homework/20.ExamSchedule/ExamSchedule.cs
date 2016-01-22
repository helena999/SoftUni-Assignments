//At SoftUni we have a new trainee Stamat, who is assigned to make schedules for the entrance exams. Since today is his first day at work he is a little bit nervous and he is not working very fast. Unfortunately, it seems that he will not have enough time to make the schedule for the next exam and there is no one else to do the job … except you of course. You will be given exam starting time in the standard 12-hour clock (hours, minutes and part of the day) and exam duration (hours and minutes). Your job is to write a program that calculates at what time the exam ends.
//Note that the standard 12-hours clock uses the following arrangements of the hours of the day: 12AM (midnight), 1AM, 2AM, 3AM, 4AM, 5AM, 6AM, 7AM, 8AM, 9AM, 10AM, 11AM, 12PM (noon), 1PM, 2PM, 3PM, 4PM, 5PM, 6PM, 7PM, 8PM, 9PM, 10PM, 11PM, 12AM, 1AM

using System;
using System.Globalization;

internal class ExamSchedule
{
    private static void Main(string[] args)
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMins = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();


        int durationHours = int.Parse(Console.ReadLine());
        int durationMins = int.Parse(Console.ReadLine());

        string startTime = startHour + ":"+ startMins + " " + partOfDay;
        DateTime start = DateTime.Parse(startTime);
        DateTime end = start.AddHours(durationHours);
        end = end.AddMinutes(durationMins);

        string format = "hh:mm:tt";
        Console.WriteLine(end.ToString(format,CultureInfo.InvariantCulture));

    }

}