using System;

namespace Collections.JaggedArrays
{
    internal static class Program
    {
        private static void Main()
        {
            Game game = new Game();
            game.PlayGame();
            Console.WriteLine("Game over");
        }
    }
}