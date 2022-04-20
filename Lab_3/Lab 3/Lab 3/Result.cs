using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Result
    {
        //public List<BoardWithPlayer> WinnerListSmallBoard  { get; set; }

       List<BoardWithPlayer> WinnerListSmallBoard = new List<BoardWithPlayer>();  //ALTERNATIVT KAN MAN INITIALIZE'A NEW LIST I KONSTRUKTORN OCH HA GET SET HÄR UPPE
        public Result(List<BoardWithPlayer> SelectedItemsByPlayer)
        {
            CheckWinSmallBoards(SelectedItemsByPlayer);
            CheckWinBigBoards(WinnerListSmallBoard);
        }
        public void CheckWinSmallBoards(List<BoardWithPlayer> SelectedItemsByPlayer)
        {
            CheckWinDiagonal(SelectedItemsByPlayer, WinnerListSmallBoard);
            CheckWinHorizontal(SelectedItemsByPlayer, WinnerListSmallBoard);
            CheckWinVertical(SelectedItemsByPlayer, WinnerListSmallBoard);

            //kanske sätta ^ till true om de lagt till nåt i winnerList, och om de finns <3 i winnerList så kör man inte CheckWinBigBoards, för då vet man ju att det är omöjligt att en bigboard vunnits.

        }
        public bool CheckWinBigBoards(List<BoardWithPlayer> WinnerList)
        {
            //var GroupByBigBoardAndPlayer = SelectedItemsByPlayer.GroupBy(x => new { x.BigBoard, x.Player });

            return true;
        }
        public bool CheckWinDiagonal(List<BoardWithPlayer> SelectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard) 
        {
            //List<BoardWithPlayer> WinnerList = new List<BoardWithPlayer>(); 
            var GroupByBigBoardAndPlayer = SelectedItemsByPlayer.GroupBy(x => new { x.BigBoard, x.Player });

            foreach (var groups in GroupByBigBoardAndPlayer)
            {
                foreach (var board in groups)
                {
                    if (groups.Any(k => k.SmallSquare!.Contains("NW") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("SE"))))
                        || groups.Any(k => k.SmallSquare!.Contains("NE") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("SW")))))
                    {
                        WinnerListSmallBoard.Add(board); 
                        this.WinnerListSmallBoard = WinnerListSmallBoard;
                    }
                }
            }
            return false;
        }
        public bool CheckWinHorizontal(List<BoardWithPlayer> SelectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard)
        {
            //List<BoardWithPlayer> WinnerList = new List<BoardWithPlayer>(); //make string list?
            var GroupByBigBoardAndPlayer = SelectedItemsByPlayer.GroupBy(x => new { x.BigBoard, x.Player });
            foreach (var groups in GroupByBigBoardAndPlayer)
            {
                foreach (var board in groups)
                {
                    if (groups.Any(k => k.SmallSquare!.Contains("NW") && groups.Any(k => k.SmallSquare!.Contains("NC") && groups.Any(k => k.SmallSquare!.Contains("NE"))))
                        || groups.Any(k => k.SmallSquare!.Contains("CW") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("CE"))))
                        || groups.Any(k => k.SmallSquare!.Contains("SW") && groups.Any(k => k.SmallSquare!.Contains("SC") && groups.Any(k => k.SmallSquare!.Contains("SE")))))
                    {
                        WinnerListSmallBoard.Add(board);
                        this.WinnerListSmallBoard = WinnerListSmallBoard;
                        //return true????
                    }
                }
            }
            return false;
        }
        public bool CheckWinVertical(List<BoardWithPlayer> SelectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard)
        {
            //List<BoardWithPlayer> WinnerList = new List<BoardWithPlayer>(); //make string list?
            var GroupByBigBoardAndPlayer = SelectedItemsByPlayer.GroupBy(x => new { x.BigBoard, x.Player });
            foreach (var groups in GroupByBigBoardAndPlayer)
            {
                foreach (var board in groups)
                {
                    if (groups.Any(k => k.SmallSquare!.Contains("NW") && groups.Any(k => k.SmallSquare!.Contains("CW") && groups.Any(k => k.SmallSquare!.Contains("SW"))))
                        || groups.Any(k => k.SmallSquare!.Contains("NC") && groups.Any(k => k.SmallSquare!.Contains("CC") && groups.Any(k => k.SmallSquare!.Contains("SC"))))
                        || groups.Any(k => k.SmallSquare!.Contains("NE") && groups.Any(k => k.SmallSquare!.Contains("CE") && groups.Any(k => k.SmallSquare!.Contains("SE")))))
                    {
                        WinnerListSmallBoard.Add(board);
                        this.WinnerListSmallBoard = WinnerListSmallBoard;
                        //return true????
                    }
                }
            }
            return false;
        }

    }
}
