using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Result
    {
        public Result(/*List<BoardWithPlayer> boardWithPlayers*/)
        {
            //CheckWinSmallBoards(boardWithPlayers);
        }
        public bool CheckWinSmallBoards(List<BoardWithPlayer> SelectedItemsByPlayer)
        {
            var BigBoards = SelectedItemsByPlayer.GroupBy(l => l.BigBoard);
            CheckWinDiagonal(BigBoards);
            CheckWinHorizontal(BigBoards);
            CheckWinVertical(BigBoards);

            return true;
        }
        public bool CheckWinDiagonal(IEnumerable<IGrouping<string?,BoardWithPlayer>> boardWithPlayers)
        {
            //foreach (var board in boardWithPlayers)
            //{
            //    Console.WriteLine("SmallBoards from bigboard " + board.Key + ":");
            //    foreach (var item in board)
            //        Console.WriteLine("* " + item.SmallSquare);
            //}
            return false;
        }
        public bool CheckWinHorizontal(IEnumerable<IGrouping<string?, BoardWithPlayer>> boardWithPlayers)
        {
            return false;
        }
        public bool CheckWinVertical(IEnumerable<IGrouping<string?, BoardWithPlayer>> boardWithPlayers)
        {
            return false;
        }

    }
}
