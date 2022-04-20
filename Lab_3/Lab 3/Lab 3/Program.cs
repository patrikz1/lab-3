using System;

namespace Lab_3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? PlayerInput = Console.ReadLine();
            if (PlayerInput != null)
            {
                new Game(new GameSetup().PopulateBoards(), new GameSetup().PopulatePlayers(), PlayerInput);
            }
        }

    }
}