using System;
namespace Lab_13
{
    public class Red : Player
    {
        public string Name
        { get; set; }

        public Red(string name) : base(name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 4);

            if (rndNum == 1)
            {
                return Roshambo.Rock.ToString();
            }
            else if (rndNum == 2)
            {
                return Roshambo.Paper.ToString();
            }
            else 
            {
                return Roshambo.Scissors.ToString();
            }
        }
    }
}