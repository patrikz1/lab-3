using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface IntGame1
    {
        Players Player { get; set; }
        Board board { get; set; }
        void MakeMoves(List<Players> PlayerList, List<Board> BoardList, string PlayerInput);
    }
}
