using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Board
    {
        public string[]? SmallSquares { get; set; }
        public string? BigSquare { get; set; }
        public Board()
        {
            SmallSquares = null; BigSquare = null; 
        }

    }
    public class BoardWithPlayer
    {
        public string? SmallSquare { get; set; }
        public string? BigBoard { get; set; }
        public string? Player { get; set; }

        public BoardWithPlayer()
        {
            SmallSquare = null; BigBoard = null; Player = null;
        }

    }
}
