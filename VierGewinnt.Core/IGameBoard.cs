using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public interface IGameBoard
    {
        IReadOnlyList<IReadOnlyList<IField>> Fields { get; }
        IReadOnlyList<Row> Rows { get; }
        IReadOnlyList<Column> Columns { get; }
        IReadOnlyList<Diagonal> Diagonals { get; }
        string DetermineWinner();
    }
}
