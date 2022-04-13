using System;

namespace Lab_3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PlayerInput = Console.ReadLine();
            new GameSetup(PlayerInput);
        }

    }
}