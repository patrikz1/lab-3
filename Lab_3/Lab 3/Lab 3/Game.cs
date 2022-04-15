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
            MakeMoves(PlayerList, BoardList, PlayerInput);
        }
        public void MakeMoves(List<Players> PlayerList, List<Board> BoardList, string PlayerInput)
        {
            var PlayerInputSplit = PlayerInput.Split('.');

            var BigBoardSplit = PlayerInputSplit[0];
            var SmallBoardSplit = PlayerInputSplit[1];

            var FindBigBoardIndex = BoardList.FindIndex(x => x.BigSquare.Equals(BigBoardSplit));
            var FindBigBoardItem = BoardList[FindBigBoardIndex];

            var FindSmallSquareIndex = BoardList.FindIndex(x => x.SmallSquares.Contains(SmallBoardSplit));
            var FindSmallSquareItem = FindBigBoardItem.SmallSquares[FindSmallSquareIndex];
            

            //var FindSmallSquare = .Where(FindBigBoardItem.SmallSquares.Equals(SmallBoardSplit);

           
            //Then place in another list (SelectedSquares) and remove from BoardList

            
            
            //längst ner player change och reiterate denna metod i guess (om jag inte måste tbx t main, men då måste man göra så att gamestup inte körs igen)
        }
    }
}
