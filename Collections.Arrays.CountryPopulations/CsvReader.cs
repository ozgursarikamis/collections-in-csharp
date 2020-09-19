using System.IO;

namespace Collections.Arrays.CountryPopulations
{
    public class CsvReader
    {
        private readonly string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            using (var streamReader = new StreamReader(_csvFilePath))
            {
                streamReader.ReadLine();

                for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = streamReader.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];

            int population = int.Parse(parts[3]);
            return new Country(name, code, region, population);
        }
    }
}