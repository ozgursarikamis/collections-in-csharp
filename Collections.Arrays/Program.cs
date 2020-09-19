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
                "Weddddnesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            days[2] = "Wednesday";

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}