//Lelia Vanche is a very keen freelance developer. She is well known for her outstanding skills, but she is also known for being pretty moody, which often affects her productivity. She also has a passion for bicycles and 10% of the normal work days she goes mountain-biking instead of working.
//You are asked to calculate whether Lelia Vanche can finish a project on time. You will be given the number of hours required to finish the project, the days that Lelia Vanche has available for working (mind that she goes to biking in 10% of this time) and her average productivity during the given period. Assume that a normal work day for Lelia Vanche has 12 hours. Note that only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).


using System;

class WorkHours
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine()); //the required work hours to finish the project
        int d = int.Parse(Console.ReadLine()); //the days available to finish the project
        int p = int.Parse(Console.ReadLine()); //the productivity in percent

        double timeForBiking = 10d/100d;
        double productivity = p/100d;

        double daysRealWork = d - (d*timeForBiking); //the days for working without biking
        double hoursRealWork = 12*daysRealWork; // 1 working day = 12 hours
        double efficientWorkHours = hoursRealWork*productivity;

        int diff = Convert.ToInt32(Math.Floor(efficientWorkHours) - h); ;

        if (efficientWorkHours >= h)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}",diff);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", diff);
        }

    }
}