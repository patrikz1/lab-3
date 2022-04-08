using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class GameSetup
    {

        public GameSetup()
        {
            populateBoards();
        }

        public void populateBoards()
        {
           //Dictionary<int, Board> boards = new Dictionary<int, Board>();
            List<Board> boards = new List<Board>();
            for (int i = 0; i< 9; i++)
            {
                boards.Add(new ()
                {
                    //BigBoard = i,
                    NW = "NW", 
                    NC = "NC",
                    NE = "NE",
                    CW = "CW",
                    CC = "CC",
                    CE = "CE",
                    SW = "SW",
                    SC = "SC",
                    SE = "SE"
                });
            }

        }
    }
}
