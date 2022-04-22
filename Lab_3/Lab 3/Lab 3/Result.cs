namespace Lab_3
{
    public class Result
    {

        List<BoardWithPlayer> WinnerListSmallBoard = new List<BoardWithPlayer>();
        List<dynamic> WinnerListBigBoard = new List<dynamic>();
        public string? WinnerPlayer { get; set; }
        public Result(List<BoardWithPlayer> SelectedItemsByPlayer)
        {
            CheckWinSmallBoards(SelectedItemsByPlayer);
            //CheckNotValid(SelectedItemsByPlayer, WinnerListSmallBoard);

            CheckWinBigBoards(WinnerListSmallBoard, WinnerListBigBoard);

        }

        public void CheckWinSmallBoards(List<BoardWithPlayer> SelectedItemsByPlayer)
        {
            CheckWinDiagonalSmallBoard(SelectedItemsByPlayer, WinnerListSmallBoard);
            CheckWinHorizontalSmallBoard(SelectedItemsByPlayer, WinnerListSmallBoard);
            CheckWinVerticalSmallBoard(SelectedItemsByPlayer, WinnerListSmallBoard);

        }
        public void CheckWinBigBoards(List<BoardWithPlayer> WinnerListSmallBoard, List<dynamic> WinnerListBigBoard /*List<dynamic> WinnerListBigBoard*/)
        {
            CheckWinDiagonalBigBoard(WinnerListSmallBoard, WinnerListBigBoard);
            CheckWinHorizontalBigBoard(WinnerListSmallBoard, WinnerListBigBoard);
            CheckWinVerticalBigBoard(WinnerListSmallBoard, WinnerListBigBoard);

        }
        public void OutputResult(List<BoardWithPlayer> WinnerListSmallBoard, List<dynamic> WinnerListBigBoard, string WinnerPlayer)
        {
            this.WinnerPlayer = WinnerPlayer;
            OutputWinningLargeSquares(WinnerListBigBoard);
            OutputWinningSmallSquares(WinnerListSmallBoard, WinnerPlayer);
            OutputWinningValues(WinnerListSmallBoard, WinnerPlayer);
        }
        public void CheckNotValid(List<BoardWithPlayer> selectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard)
        {
            BoardWithPlayer CurrentItem = selectedItemsByPlayer.Last();

            foreach (var item in selectedItemsByPlayer)
            {
                if (item != CurrentItem)
                {
                    bool containsBigBoard = item.BigBoard!.Equals(CurrentItem.BigBoard);
                    bool containsSmallSquare = item.SmallSquare!.Equals(CurrentItem.SmallSquare);

                    if (containsBigBoard && containsSmallSquare) // || (or) board already complete (when i have done the result)---  WinnerListSmallBoard.Any(k => k.BigBoard!.Contains(CurrentItem.BigBoard))
                    {
                        selectedItemsByPlayer.Remove(CurrentItem);
                    }
                }
            }
        }

      
        public void OutputWinningLargeSquares(List<dynamic> WinnerListBigBoard)
        {
            Console.WriteLine("\nResults:");
            foreach (var item in WinnerListBigBoard)
            {
                foreach (var i in item)
                {
                    Console.Write(i.BigBoard + ",");
                }
            }
        }
        public void OutputWinningSmallSquares(List<BoardWithPlayer> WinnerListSmallBoard, string WinnerPlayer)
        {
            Console.WriteLine();
            foreach (var item in WinnerListSmallBoard.GroupBy(item => item.Player!.Contains(WinnerPlayer)))
            {
                if (item.Key == true)
                {
                    foreach (var i in item)
                    {
                        Console.Write(i.BigBoard + "." + i.SmallSquare + ", ");
                    }
                }
            }
        }
        public void OutputWinningValues(List<BoardWithPlayer> WinnerListSmallBoard, string WinnerPlayer)
        {
            Console.WriteLine();
            foreach (var item in WinnerListSmallBoard.GroupBy(item => item.Player!.Contains(WinnerPlayer)))
            {
                if (item.Key == true)
                {
                    Console.Write(1 + "." + item.Count() / 3 + ", ");
                }
                else if (item.Key == false)
                {
                    Console.Write(0 + "." + item.Count() / 3 + ", ");
                }
            }
            if (WinnerListSmallBoard.All(i => i.Player!.Contains(WinnerPlayer)))
            {
                Console.Write(0 + "." + 0);
            }
            Console.WriteLine("\n");
        }
        public void CheckWinDiagonalBigBoard(List<BoardWithPlayer> WinnerListSmallBoard, List<dynamic> WinnerListBigBoard)
        {
            var SelectWonBoardAndPlayer = WinnerListSmallBoard.GroupBy(x => new { x.BigBoard, x.Player }).Select(i => new { i.Key.BigBoard, i.Key.Player });
            foreach (var groups in SelectWonBoardAndPlayer.GroupBy(x => x.Player))
            {
                foreach (var item in groups)
                {
                    if (groups.Any(k => k.BigBoard!.Contains("NW")) && groups.Any(k => k.BigBoard!.Contains("CC") && groups.Any(k => k.BigBoard!.Contains("SE")))
                        || groups.Any(k => k.BigBoard!.Contains("NE")) && groups.Any(k => k.BigBoard!.Contains("CC") && groups.Any(k => k.BigBoard!.Contains("SW"))))
                    {
                        if (!WinnerListBigBoard.Contains(groups))
                        {
                            WinnerListBigBoard.Add(groups);
                            OutputResult(WinnerListSmallBoard, WinnerListBigBoard, groups.Key!);
                        }
                    }

                }
            }
        }
        public void CheckWinHorizontalBigBoard(List<BoardWithPlayer> WinnerListSmallBoard, List<dynamic> WinnerListBigBoard)
        {
            var SelectWonBoardAndPlayer = WinnerListSmallBoard.GroupBy(x => new { x.BigBoard, x.Player }).Select(i => new { i.Key.BigBoard, i.Key.Player });
            foreach (var groups in SelectWonBoardAndPlayer.GroupBy(x => x.Player))
            {
                foreach (var item in groups)
                {
                    if (groups.Any(k => k.BigBoard!.Contains("NW")) && groups.Any(k => k.BigBoard!.Contains("NC") && groups.Any(k => k.BigBoard!.Contains("NE")))
                        || groups.Any(k => k.BigBoard!.Contains("CW")) && groups.Any(k => k.BigBoard!.Contains("CC") && groups.Any(k => k.BigBoard!.Contains("CE")))
                        || groups.Any(k => k.BigBoard!.Contains("SW")) && groups.Any(k => k.BigBoard!.Contains("SC") && groups.Any(k => k.BigBoard!.Contains("SE"))))
                    {
                        if (!WinnerListBigBoard.Contains(groups))
                        {
                            WinnerListBigBoard.Add(groups);
                            OutputResult(WinnerListSmallBoard, WinnerListBigBoard,groups.Key!);
                        }
                    }
                }
            }
        }
        public void CheckWinVerticalBigBoard(List<BoardWithPlayer> WinnerListSmallBoard, List<dynamic> WinnerListBigBoard)
        {
            var SelectWonBoardAndPlayer = WinnerListSmallBoard.GroupBy(x => new { x.BigBoard, x.Player }).Select(i => new { i.Key.BigBoard, i.Key.Player });
            foreach (var groups in SelectWonBoardAndPlayer.GroupBy(x => x.Player))
            {
                foreach (var item in groups)
                {
                    if (groups.Any(k => k.BigBoard!.Contains("NW")) && groups.Any(k => k.BigBoard!.Contains("CW") && groups.Any(k => k.BigBoard!.Contains("SW")))
                    || groups.Any(k => k.BigBoard!.Contains("NC")) && groups.Any(k => k.BigBoard!.Contains("CC") && groups.Any(k => k.BigBoard!.Contains("SC")))
                    || groups.Any(k => k.BigBoard!.Contains("NE")) && groups.Any(k => k.BigBoard!.Contains("CE") && groups.Any(k => k.BigBoard!.Contains("SE"))))
                    {
                        if (!WinnerListBigBoard.Contains(groups))
                        {
                            WinnerListBigBoard.Add(groups);
                            OutputResult(WinnerListSmallBoard, WinnerListBigBoard, groups.Key!);

                        }
                    }
                }
            }

        }
        public void CheckWinDiagonalSmallBoard(List<BoardWithPlayer> SelectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard)
        {
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
        }
        public void CheckWinHorizontalSmallBoard(List<BoardWithPlayer> SelectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard)
        {
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
                    }
                }
            }
        }
        public void CheckWinVerticalSmallBoard(List<BoardWithPlayer> SelectedItemsByPlayer, List<BoardWithPlayer> WinnerListSmallBoard)
        {
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
                    }
                }
            }
        }
    }
}
