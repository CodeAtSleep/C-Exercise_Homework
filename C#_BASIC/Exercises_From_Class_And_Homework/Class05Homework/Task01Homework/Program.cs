using System;

namespace Task01Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Today;
            //Console.WriteLine(now);

            //Print the date that is 3 days from now
            DateTime daysFromNow = now.AddDays(3) ;
            Console.WriteLine("The date three days from now is " + daysFromNow);

            //Print the date that is one month from now
            DateTime monthFromNow = now.AddMonths(1);
            Console.WriteLine("The date one month from now is " + monthFromNow);

            //Print the date that is one month and 3 days from now
            DateTime monthAndThreeDays = now.AddMonths(1).AddDays(3);
            Console.WriteLine("The date one month and three days from now is " + monthAndThreeDays);

            //Print 1 year and 2 months ago from today
            DateTime yearAndTwoMonths = now.AddYears(-1).AddMonths(-2);
            Console.WriteLine("The date a year and two months ago was " + yearAndTwoMonths);

            //Print only the current month of today
            DateTime currentMonth = DateTime.Now;
            Console.WriteLine("The current month now is " + currentMonth.Month);

            //Print only the current year of today
            DateTime currentYear = DateTime.Now;
            Console.WriteLine("The current year now is " + currentYear.Year);

            Console.ReadLine();
        }
    }
}
