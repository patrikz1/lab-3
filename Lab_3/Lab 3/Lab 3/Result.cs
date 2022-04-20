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
        public bool CheckWinDiagonal(IEnumerable<IGrouping<string?,BoardWithPlayer>> BigBoards)
        {

            foreach (var groups in BigBoards)
            {
                foreach(var board in groups)
                {

                }

            }
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
