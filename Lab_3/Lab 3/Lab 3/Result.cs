using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Result
    {
        public List<BoardWithPlayer> WinnerList { get; set; }
        public Result(/*List<BoardWithPlayer> boardWithPlayers*/)
        {
            //CheckWinSmallBoards(boardWithPlayers);
        }
        public bool CheckWinSmallBoards(List<BoardWithPlayer> SelectedItemsByPlayer)
        {
           var BigBoards = SelectedItemsByPlayer.GroupBy(l => l.BigBoard).ToList(); //bort med tolist
            CheckWinDiagonal(BigBoards);
            CheckWinHorizontal(BigBoards);
            CheckWinVertical(BigBoards);

            return true;
        }
        public bool CheckWinDiagonal(List<IGrouping<string?, BoardWithPlayer>> BigBoards) /**/  //Ienumerable ist för list
        {
            List<BoardWithPlayer> WinnerList = new List<BoardWithPlayer>(); //make string list?
            foreach (var groups in BigBoards)
            {
                foreach (var board in groups)
                {
                    if (groups.Any(k => k.SmallSquare!.Contains("NW") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("SE"))))
                        || groups.Any(k => k.SmallSquare!.Contains("NE") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("SW")))))
                        //and Check player = the same aswell
                    {
                        // WinnerList.Add(groups.key, player???); 
                        this.WinnerList = WinnerList;
                        //return true????
                    }
                }
            }
            return false;
        }
        public bool CheckWinHorizontal(List<IGrouping<string?, BoardWithPlayer>> BigBoards)
        {
            List<BoardWithPlayer> WinnerList = new List<BoardWithPlayer>(); //make string list?
            foreach (var groups in BigBoards)
            {
                foreach (var board in groups)
                {
                    if (groups.Any(k => k.SmallSquare!.Contains("NW") && groups.Any(k => k.SmallSquare!.Contains("NC") && groups.Any(k => k.SmallSquare!.Contains("NE"))))
                        || groups.Any(k => k.SmallSquare!.Contains("CW") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("CE"))))
                        || groups.Any(k => k.SmallSquare!.Contains("SW") && groups.Any(k => k.SmallSquare!.Contains("SC") && groups.Any(k => k.SmallSquare!.Contains("SE")))))
                    //and Check player = the same aswell
                    {
                        // WinnerList.Add(groups.key, player???); 
                        this.WinnerList = WinnerList;
                        //return true????
                    }
                }
            }
            return false;
        }
        public bool CheckWinVertical(IEnumerable<IGrouping<string?, BoardWithPlayer>> BigBoards)
        {
            List<BoardWithPlayer> WinnerList = new List<BoardWithPlayer>(); //make string list?
            foreach (var groups in BigBoards)
            {
                foreach (var board in groups)
                {
                    if (groups.Any(k => k.SmallSquare!.Contains("NW") && groups.Any(k => k.SmallSquare!.Contains("CW") && groups.Any(k => k.SmallSquare!.Contains("SW"))))
                        || groups.Any(k => k.SmallSquare!.Contains("NC") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("SC"))))
                        || groups.Any(k => k.SmallSquare!.Contains("NE") && groups.Any(k => k.SmallSquare!.Contains("CE") && groups.Any(k => k.SmallSquare!.Contains("SE")))))
                    //and Check player = the same aswell
                    {
                        // WinnerList.Add(groups.key, player???); 
                        this.WinnerList = WinnerList;
                        //return true????
                    }
                }
            }
            return false;
        }

    }
}
