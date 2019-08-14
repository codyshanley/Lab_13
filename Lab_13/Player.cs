using System;
namespace Lab_13
{
    public abstract class Player
    {
        string Name
        { get; }

        public Player(string name)
        {
            Name = name;
        }

        public abstract string GenerateRoshambo();
    }
}
