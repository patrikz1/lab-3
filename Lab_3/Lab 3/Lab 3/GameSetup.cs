using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class GameSetup
    {
        //vet ej om denna behövs, tänker att då har man listan ifylld efter man hoppat ur populateBoards men vet ej
        public List<Board>? boards;
        public GameSetup()
        {
            populateBoards();
        }

        public void populateBoards()
        {
            string[] SmallSquares = new string[9] { "NW", "NC", "NE", "CW", "CC", "CE", "SW", "SC", "SE" };
            List<Board> boards = new List<Board>();
            for (int i = 0; i < SmallSquares.Length; i++)
            {
                string? BigSquare = SmallSquares.GetValue(i).ToString();
                boards.Add( new()
                {
                    BigSquare = BigSquare,
                    SmallSquares = SmallSquares,

                }) ;
            }
           //Connected t kommentaren där uppe
            this.boards = boards;
        }
    }
}
