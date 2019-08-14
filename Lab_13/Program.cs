using System;
using System.Threading;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.Write("Enter your name: ");
            Human user = new Human(Console.ReadLine());
            Console.Clear();

            while (true)
            {
                Console.WriteLine($"Hey {user.Name}! Please select your opponent below:\n");
                Console.WriteLine("1. Andy Dufresne");
                Console.WriteLine("2. Red\n");
                Console.Write("Enter a 1 or 2: ");

                int opponentNum;

                while (true)
                {
                    try
                    {
                        opponentNum = int.Parse(Console.ReadLine());

                        if (opponentNum == 1 || opponentNum == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a 1 or 2: ");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a 1 or 2: ");
                    }
                }

                Console.Clear();

                if (opponentNum == 1)
                {
                    AndyDufresne andy = new AndyDufresne("Andy Dufresne");

                    string userResult = user.GenerateRoshambo();
                    string opponentResult = andy.GenerateRoshambo();

                    Console.WriteLine("\nPress ENTER to challenge " + andy.Name + " ...\n");
                    Console.ReadLine();

                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);

                    Console.Clear();

                    Console.WriteLine(andy.Name + ": " + opponentResult);
                    Console.WriteLine(user.Name + ": " + userResult + "\n");

                    if (userResult == opponentResult)
                        Console.WriteLine("Draw!\n");
                    else if (userResult == Roshambo.Paper.ToString())
                        Console.WriteLine(user.Name + " wins!");
                    else if (userResult == Roshambo.Scissors.ToString())
                        Console.WriteLine("Andy Dufresne wins! Zihuatanejo here we come!");

                    string againResponse;

                    while (true)
                    {
                        Console.Write("\nWould you like to play again? (y/n): ");
                        againResponse = Console.ReadLine().ToLower();

                        if (againResponse != "y" && againResponse != "n")
                        {
                            Console.WriteLine("\nPlease enter a y or n.\n");
                            continue;
                        }
                        else
                            break;
                    }

                    if (againResponse == "n")
                    {
                        Console.WriteLine("\nThanks for playing!");
                        break;
                    }
                }

                if (opponentNum == 2)
                {
                    Red red = new Red("Red");

                    string userResult = user.GenerateRoshambo();
                    string opponentResult = red.GenerateRoshambo();

                    Console.WriteLine("\nPress ENTER to challenge Red...\n");
                    Console.ReadLine();

                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.WriteLine(".\n");
                    Thread.Sleep(250);

                    Console.Clear();

                    Console.WriteLine("Red: " + opponentResult);
                    Console.WriteLine(user.Name + ": " + userResult + "\n");

                    if (userResult == opponentResult)
                        Console.WriteLine("Draw!\n");
                    else if (userResult == Roshambo.Paper.ToString() && opponentResult == Roshambo.Rock.ToString())
                        Console.WriteLine(user.Name + " wins!");
                    else if (userResult == Roshambo.Paper.ToString() && opponentResult == Roshambo.Scissors.ToString())
                        Console.WriteLine(red.Name + " wins!");

                    else if (userResult == Roshambo.Rock.ToString() && opponentResult == Roshambo.Scissors.ToString())
                        Console.WriteLine(user.Name + " wins!");
                    else if (userResult == Roshambo.Rock.ToString() && opponentResult == Roshambo.Paper.ToString())
                        Console.WriteLine(red.Name + " wins!");

                    else if (userResult == Roshambo.Scissors.ToString() && opponentResult == Roshambo.Paper.ToString())
                        Console.WriteLine(user.Name + " wins!");
                    else if (userResult == Roshambo.Scissors.ToString() && opponentResult == Roshambo.Rock.ToString())
                        Console.WriteLine(red.Name + " wins!");

                    string againResponse;

                    while (true)
                    {
                        Console.Write("\nWould you like to play again? (y/n): ");
                        againResponse = Console.ReadLine().ToLower();

                        if (againResponse != "y" && againResponse != "n")
                        {
                            Console.WriteLine("\nPlease enter a y or n.\n");
                            continue;
                        }
                        else
                            break;
                    }

                    if (againResponse == "n")
                    {
                        Console.WriteLine("\nThanks for playing!");
                        break;
                    }

                    Console.Clear();
                }
            }
        }
    }
}
