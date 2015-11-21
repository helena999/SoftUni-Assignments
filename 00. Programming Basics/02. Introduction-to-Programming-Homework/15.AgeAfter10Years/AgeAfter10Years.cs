//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Calculate your age after 10 years.");
            Console.Write("Write your birthday: ");
            DateTime yourBirthday = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            int yourAge = currentDate.Year - yourBirthday.Year;
            

            if ((yourBirthday.Month == currentDate.Month && yourBirthday.Day > currentDate.Day) || (yourBirthday.Month > currentDate.Month))
            {
                Console.WriteLine("Your age now: {0}", yourAge - 1);
                Console.WriteLine("Your age after 10 years will be: {0}", yourAge + 9);
            }
            else
            {
                Console.WriteLine("Your age now: {0}", yourAge);
                Console.WriteLine("Your age after 10 years will be: {0}", yourAge + 10);
            }

        }
    }
