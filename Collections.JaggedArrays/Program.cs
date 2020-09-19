using System;

namespace Collections.JaggedArrays
{
    internal static class Program
    {
        private static void Main()
        {
            int[,] arr = new int[3, 3]; // declaration
            arr[0, 1] = 10; // initialization
            arr[1, 2] = 20; // initialization
            arr[2, 0] = 30; // initialization

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]);
                }

                Console.WriteLine();
            }

            // declaration and initialization:
            int[,] arr2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }

                Console.WriteLine();
            }
            
        }
    }
}