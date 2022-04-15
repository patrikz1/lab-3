using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class GameSetup
    {
      public string PlayerInput { get; set; }
        public GameSetup(string PlayerInput)
        {
            this.PlayerInput = PlayerInput;
            PopulateBoards();
        }

        public void PopulateBoards()
        {
            string[] SmallSquares = new string[9] { "NW", "NC", "NE", "CW", "CC", "CE", "SW", "SC", "SE" };
            List<Board> boards = new List<Board>();
            for (int i = 0; i < SmallSquares.Length; i++)
            {
                string? BigSquare = SmallSquares.GetValue(i).ToString();
                boards.Add( new()
                {
                    BigSquare = BigSquare,
                    SmallSquares = SmallSquares,
                }) ;
            }
            PopulatePlayers(boards);
        }
        public void PopulatePlayers(List<Board> BoardList)
        {

            string[] Players = new string[2] { "O", "X" };
            var PlayerList = new List<Players>();

            for (int i = 0; i < Players.Length; i++)
            {
                string? PlayersIteration = Players.GetValue(i).ToString();
                PlayerList.Add(new()
                {
                    Player = PlayersIteration,
                });
            }

            new Game(BoardList, PlayerList, PlayerInput);

        }
    }
}
