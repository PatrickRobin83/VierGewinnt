using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core
{
    public class GameBoard : IGameBoard
    {
        private readonly IReadOnlyList<IReadOnlyList<IField>> _fields;
        private readonly IReadOnlyList<Row> _rows;
        private readonly IReadOnlyList<Column> _columns;
        private readonly IReadOnlyList<Diagonal> _diagonals;
        private readonly IReadOnlyList<Line> _gameBoardLines;
        public GameBoard(IReadOnlyList<IReadOnlyList<IField>> fields, 
               IReadOnlyList<Row> rows, 
               IReadOnlyList<Column> columns, 
               IReadOnlyList<Diagonal> diagonals)
        {
            _fields = fields ?? throw new ArgumentNullException(nameof(fields));
            _rows = rows ?? throw new ArgumentNullException(nameof(rows));
            _columns = columns ?? throw new ArgumentNullException(nameof(columns));
            _diagonals = diagonals ?? throw new ArgumentNullException(nameof(diagonals));

            _gameBoardLines = rows.Cast<Line>().Concat(columns).Concat(diagonals).ToList();
        }

        public IReadOnlyList<IReadOnlyList<IField>> Fields => _fields;

        public IReadOnlyList<Row> Rows => _rows;
        public IReadOnlyList<Column> Columns => _columns;
        public IReadOnlyList<Diagonal> Diagonals => _diagonals;
        public string DetermineWinner()
        {
            foreach (var line in _gameBoardLines)
            {
                var winnerName = line.CheckIfPlayerHasFourGamePiecesInARow();
                if (winnerName != null)
                    return winnerName;
            }

            return null;
        }
    }
}