namespace BeerTime
{
    using System;
    using System.Globalization;
    class BeerTime
    {
        static CultureInfo provider = CultureInfo.InvariantCulture;
        static DateTime evening = DateTime.ParseExact("01:00 PM", "hh:mm tt", provider);
        static DateTime morning = DateTime.ParseExact("03:00 AM", "hh:mm tt", provider);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in format hh:mm tt");
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", provider);

            Console.WriteLine(IsBeerTime(time) ? "beer time" : "non-beer time");

        }

        private static bool IsBeerTime(DateTime time)
        {
            bool afterEvening = time.TimeOfDay.CompareTo(evening.TimeOfDay) >= 0;
            bool beforeMorning = time.TimeOfDay.CompareTo(morning.TimeOfDay) < 0;

            return afterEvening || beforeMorning;

        }
    }
}
