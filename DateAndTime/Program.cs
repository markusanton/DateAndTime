using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("2day: " + today);
            
            int yearToday = today.Year;
            Console.WriteLine("current year: " + yearToday);

            var dayOfWeekNow = today.DayOfWeek;
            Console.WriteLine("day: " + dayOfWeekNow);

            DateTime todayNow = DateTime.Now;
            Console.WriteLine("local time: " + todayNow);
            DateTime UTC = DateTime.UtcNow;
            Console.WriteLine("utc: " + UTC);

            DateTime xmasEve = new DateTime(yearToday, 12, 24);
            var xmasEveWeek = xmasEve.DayOfWeek;
            Console.WriteLine(xmasEveWeek);
        }
    }
}
