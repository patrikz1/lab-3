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

            //måste fixas, för nu kollar jag om de finns någon index där de är lika med inputen, när alla NW t.ex har tagits så måste den säga "finns inga NW kvar"
            //alternativt kolla om den specifika finns i nya listan som vi skapar (SelectedItems) för på så sätt slipper vi ta bort från gamla listan å kmr alltid finnas NW kvar
            //men då kollar vi om de finns en NW.NW i SelectedItmes å om de inte finns lägger vi till den där.
            var FindSmallSquareIndex = BoardList.FindIndex(x => x.SmallSquares.Contains(SmallBoardSplit));
            var FindSmallSquareItem = FindBigBoardItem.SmallSquares[FindSmallSquareIndex];




            //längst ner player change och reiterate denna metod i guess (om jag inte måste tbx t main, men då måste man göra så att gamestup inte körs igen)
        }
    }
}
