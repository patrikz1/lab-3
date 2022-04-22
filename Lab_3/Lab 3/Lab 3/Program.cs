using System;

namespace Lab_3 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? PlayerInput = Console.ReadLine(); // args[0];
            if (PlayerInput != null)
            {
                new Game(new GameSetup().PopulateBoards(), new GameSetup().PopulatePlayers(), PlayerInput);
            }
        }

    }
}