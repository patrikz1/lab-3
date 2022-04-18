using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Game
    {
        public Game(List<Board> BoardList, List<Players> PlayerList, string PlayerInput)
        {
            //Alternativt göra MakeMoves Void och göra sista linjen på den new result(SelectedItemsByPlayer)
            new Result(MakeMoves(PlayerList, BoardList,PlayerInput));
        }

        public List<BoardWithPlayer> MakeMoves(List<Players> PlayerList, List<Board> BoardList, string PlayerInput)
        {
            var SelectedItemsByPlayer = new List<BoardWithPlayer>();
            PlayerInput = PlayerInput.Replace(" ", "");
            var MoveSplit = PlayerInput.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (MoveSplit.Length > 0)
            {
                foreach (var move in MoveSplit)
                {
                    var SquareSplit = move.Split('.');
                    var BigBoardSplit = SquareSplit[0].ToUpper();
                    var SmallSquareSplit = SquareSplit[1].ToUpper();

                    var FindBigBoardIndex = BoardList.FindIndex(x => x.BigSquare.Equals(BigBoardSplit));
                    var FindBigBoardItem = BoardList[FindBigBoardIndex];
                    var FindSmallSquareIndex = Array.FindIndex(FindBigBoardItem.SmallSquares, row => row.Contains(SmallSquareSplit));

                    var SmallSquare = FindBigBoardItem.SmallSquares[FindSmallSquareIndex];
                    var BigBoard = FindBigBoardItem.BigSquare;

                    SelectedItemsByPlayer.Add(new()
                    {
                        BigBoard = BigBoard,
                        SmallSquare = SmallSquare,
                        Player = CurrentPlayer(PlayerList)
                    });
                }
            }
            return SelectedItemsByPlayer;
        }

        public string CurrentPlayer(List<Players> PlayerList)
        {
            // Return player name based on Last entry player in SelectedItemsByPlayers list (take the other one, so its 1-2-1-2).
            return "X";
        }
    }
}
