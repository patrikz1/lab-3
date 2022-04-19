using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class GameSetup
    {
        public GameSetup()
        {

        }
        //Denna hade förut båda dessa metoder som void, string playerinput som inparameter för gamesetup och sen i konstruktorn körde vi PopulateBoards()
        //som i sin tur avslutades med att köra PopulatePlayers och skicka med boards listan som inparameter för PopulatePlayers()
        //I populate players avslutade vi med att göra en ny Game och skickade med boards som den fått från PopulateBoards, Playerinput från konstruktorn och
        //playerList som den själv genererat
        public List<Board> PopulateBoards()
        {
            string[] SmallSquares = new string[9] { "NW", "NC", "NE", "CW", "CC", "CE", "SW", "SC", "SE" };
            List<Board> boards = new List<Board>();
            for (int i = 0; i < SmallSquares.Length; i++)
            {
                string? BigSquare = SmallSquares.GetValue(i)!.ToString();
                boards.Add(new()
                {
                    BigSquare = BigSquare,
                    SmallSquares = SmallSquares,
                }) ;
            }
            return boards;
        }
        public List<Players> PopulatePlayers()
        {

            string[] Players = new string[2] { "X", "O" };
            var PlayerList = new List<Players>();

            for (int i = 0; i < Players.Length; i++)
            {
                string? PlayersIteration = Players.GetValue(i)!.ToString();
                PlayerList.Add(new()
                {
                    Player = PlayersIteration,
                }) ;
            }
            return PlayerList;
        }
    }
}
