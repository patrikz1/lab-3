using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Game
    {
        public Game(List<Board> BoardList, List<Players> PlayerList, string PlayerInput)
        {
            MakeMoves(PlayerList, BoardList, PlayerInput);
        }

        public List<BoardWithPlayer> MakeMoves(List<Players> PlayerList, List<Board> BoardList, string PlayerInput)
        {
            var SelectedItemsByPlayer = new List<BoardWithPlayer>();
            PlayerInput = PlayerInput.Replace(" ", "");
            var MoveSplit = PlayerInput.Split(',', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
                if (MoveSplit.Length > 0)
                {
                    foreach (var move in MoveSplit)
                    {
                        try
                        {
                            var SquareSplit = move.Split('.');
                            var BigBoardSplit = SquareSplit[0].ToUpper();
                            var SmallSquareSplit = SquareSplit[1].ToUpper();

                            var FindBigBoardIndex = BoardList.FindIndex(x => x.BigSquare!.Equals(BigBoardSplit));
                            var FindBigBoardItem = BoardList[FindBigBoardIndex];
                            var FindSmallSquareIndex = Array.FindIndex(FindBigBoardItem.SmallSquares!, x => x.Contains(SmallSquareSplit));

                            var SmallSquare = FindBigBoardItem.SmallSquares![FindSmallSquareIndex];
                            var BigBoard = FindBigBoardItem.BigSquare;

                            SelectedItemsByPlayer.Add(new()
                            {
                                BigBoard = BigBoard,
                                SmallSquare = SmallSquare,
                                Player = CurrentPlayer(PlayerList, SelectedItemsByPlayer)
                            });

                            var result = new Result(SelectedItemsByPlayer);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\"" + move + "\"" + " was not valid due to incorrect format, that board was already won or was a duplicate move");
                        }

                    }
                }
            return SelectedItemsByPlayer;
        }
        public string CurrentPlayer(List<Players> PlayerList, List<BoardWithPlayer> SelectedItems)
        {

            if (SelectedItems.Count % 2 == 0 || SelectedItems.Count == 0)
                {
                    return PlayerList[0].Player!.ToString();
                }
            else
                {
                    return PlayerList[1].Player!.ToString();
                }
        }
    }
}
