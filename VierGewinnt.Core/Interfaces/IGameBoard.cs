using System.Collections.Generic;

namespace VierGewinnt.Core.Interfaces
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
