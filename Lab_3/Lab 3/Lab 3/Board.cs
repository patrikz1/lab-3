using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Board
    {
        public string[]? SmallSquares { get; set; } = null;
        public string? BigSquare { get; set; } = null;
        public Board()
        {
            //SmallSquares = null; BigSquare = null; 
        }

    }
    public class BoardWithPlayer
    {
        public string? SmallSquare { get; set; } = null;
        public string? BigBoard { get; set; } = null;
        public string? Player { get; set; } = null;

        public BoardWithPlayer()
        {
            //SmallSquare = null; BigBoard = null; Player = null;
        }

    }
}
