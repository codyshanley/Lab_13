using System;
namespace Lab_13
{
    public class AndyDufresne : Player
    {
        public string Name
        { get; set; }

        public AndyDufresne(string name) : base(name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            return Roshambo.Rock.ToString();
        }
    }
}
