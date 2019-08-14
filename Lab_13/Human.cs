using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13
{
    class Human : Player
    {
        public string Name
        { get; }

        public Human(string name) : base(name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            Console.WriteLine("Please select from the following: \n");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors\n");

            string input = Console.ReadLine().Trim();

            if (input == "1")
            {
                return Roshambo.Rock.ToString();
            }
            else if (input == "2")
            {
                return Roshambo.Paper.ToString();
            }
            else if (input == "3")
            {
                return Roshambo.Scissors.ToString();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry I didn't follow that response. Let's try again");
                return GenerateRoshambo();
            }
        }
    }
}