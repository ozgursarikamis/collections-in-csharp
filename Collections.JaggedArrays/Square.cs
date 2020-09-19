using System;

namespace Collections.JaggedArrays
{
    public enum Player
    {
        None = 0,
        Noughts,
        Crosses
    };
    
    public readonly struct Square
    {
        public Player Owner { get; }
        public Square(Player owner)
        {
            Owner = owner;
        }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.None:
                    return ".";
                case Player.Crosses:
                    return "X";
                case Player.Noughts:
                    return "0";
                default:
                    throw new Exception("Invalid State");
            }
        }
    }
}