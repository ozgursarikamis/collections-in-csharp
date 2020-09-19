using System;
using System.Collections.Generic;

namespace Collection.Dictionaries
{
    internal static class Program
    {
        private static void Main()
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_303);

            var countries = new Dictionary<string, Country>
            {
                {norway.Code, norway},
                {finland.Code, finland}
            };
            
            // Look up item in dictionary:
            var fin = countries["FIN"];
            Console.WriteLine(fin.Name);
        }
    }
}