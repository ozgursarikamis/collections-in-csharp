using System;

namespace Collections.Arrays
{
    internal static class Program
    {
        private static void Main()
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Which day do you want to display?");
            Console.WriteLine("Monday = 1 etc... >>>");

            var iDay = int.Parse(Console.ReadLine() ?? string.Empty);

            string chosenDay = days[iDay];
            Console.WriteLine($"The day is {chosenDay}");
        }
    }
}