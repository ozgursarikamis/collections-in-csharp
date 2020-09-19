using System;
using System.Linq;

namespace Collections.ArrayEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] bankHols = {
                new DateTime(2020, 12, 31),
                new DateTime(2021, 1, 1),
            };

            DateTime[] bankHols2 = {
                new DateTime(2020, 12, 31),
                new DateTime(2021, 1, 1),
            };

            System.Console.WriteLine($"hols1 == hols2 ?: { bankHols == bankHols2 }");
            System.Console.WriteLine(bankHols.SequenceEqual(bankHols2));
        }
    }
}
