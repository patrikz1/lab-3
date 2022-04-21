using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface IBoard
    {
        string? SmallSquare { get; set; }
        string? BigSquare { get; set; } //refererar inte till alla pga av nåt fel, ska hitta lösning
        string[]? SmallSquares { get; set; } //samma problem
        string? BigBoard { get; set; }
        string? Player { get; set; }
    }
}
