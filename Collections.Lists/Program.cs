using System;
using System.Collections.Generic;

namespace Collections.Lists
{
    internal static class Program
    {
        private static void Main()
        {
            var countries = new List<string>
            {
                "The USA", "The UK", "The Netherlands", "Germany"
            };

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();
            
            countries.Insert(3, "Switzerland");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            var germanyIndex = countries.FindIndex(x => x == "Germany");
            Console.WriteLine(germanyIndex);
        }
    }
}