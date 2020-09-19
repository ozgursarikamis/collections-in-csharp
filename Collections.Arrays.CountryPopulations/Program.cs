using System;
using System.IO;

namespace Collections.Arrays.CountryPopulations
{
    internal static class Program
    {
        private static void Main()
        {
            FileInfo fileInfo = new FileInfo(
                Path.Combine(
                    Environment.CurrentDirectory, "Pop by Largest Final.csv"));
            
            CsvReader reader = new CsvReader(fileInfo.Name);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (var country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population)}");
            }
        }
    }
}