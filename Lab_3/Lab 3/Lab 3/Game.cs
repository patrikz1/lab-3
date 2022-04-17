using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Game
    {
        public List<BoardWithPlayer> SelectedItemsByPlayer { get; set; }
        public Game(List<Board> BoardList, List<Players> PlayerList, string PlayerInput)
        {
            MakeMoves(PlayerList, BoardList, PlayerInput);
        }
 
        public void MakeMoves(List<Players> PlayerList, List<Board> BoardList, string PlayerInput)
        {
            var PlayerInputSplit = PlayerInput.Split('.');

            var BigBoardSplit = PlayerInputSplit[0].ToUpper();
            var SmallSquareSplit = PlayerInputSplit[1].ToUpper();

            var FindBigBoardIndex = BoardList.FindIndex(x => x.BigSquare.Equals(BigBoardSplit));
            var FindBigBoardItem = BoardList[FindBigBoardIndex];
            var FindSmallSquareIndex = Array.FindIndex(FindBigBoardItem.SmallSquares, row => row.Contains(SmallSquareSplit));

            var SmallSquare = FindBigBoardItem.SmallSquares[FindSmallSquareIndex];
            var BigBoard = FindBigBoardItem.BigSquare;

            var SelectedItemsByPlayer = new List<BoardWithPlayer>();
            SelectedItemsByPlayer.Add(new()
            {
                BigBoard = BigBoard,
                SmallSquare = SmallSquare,
                Player = CurrentPlayer(PlayerList)
            });

            this.SelectedItemsByPlayer = SelectedItemsByPlayer;
            // sen kanske vi måste serialize'a denna lista så den hålls kvar å inte "tappar" sina förra val. utan har en xml fil med alla föredetta val.

        }

        public string CurrentPlayer(List<Players> PlayerList)
        {
            // Return player name based on Last entry player in SelectedItemsByPlayers list (take the other one, so its 1-2-1-2).
            return "X";
        }
    }
}
