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

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            var points = new[] {
                new System.Drawing.Point(3, 5)
            };
            
            // or:
            System.Drawing.Point[] _points =
            {
                new System.Drawing.Point(3, 5)
            };
        }
    }
}