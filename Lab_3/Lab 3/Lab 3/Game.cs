﻿using System;
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
            MakeMoves(PlayerList, BoardList,PlayerInput);
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
                    var FindSmallSquareIndex = Array.FindIndex(FindBigBoardItem.SmallSquares, x => x.Contains(SmallSquareSplit));

                    var SmallSquare = FindBigBoardItem.SmallSquares[FindSmallSquareIndex];
                    var BigBoard = FindBigBoardItem.BigSquare;
                    if (IsValid())
                    {
                        SelectedItemsByPlayer.Add(new()
                        {
                            BigBoard = BigBoard,
                            SmallSquare = SmallSquare,
                            Player = CurrentPlayer(PlayerList)
                        });
                    }
                    var result = new Result().CheckWinSmallBoards(SelectedItemsByPlayer);
                    if(result == true)
                    {
                        // add to a list of boards that has been won, then if you try to add something that is in this list again = not valid 
                    }
                    
                }
            }
            return SelectedItemsByPlayer;
        }
        public bool IsValid()
        {
            //Return true if move not already in SelectedItemsByPlayer
            return true;
        }

        public string CurrentPlayer(List<Players> PlayerList)
        {
            //Varannan player, X-O-X-O etc.
            return "X";
        }
    }
}
