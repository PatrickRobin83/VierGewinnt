using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class GameBoard
    {
        private readonly IReadOnlyList<IReadOnlyList<Field>> _fields;
        private readonly IReadOnlyList<Row> _rows;
        private readonly IReadOnlyList<Column> _columns;
        private readonly IReadOnlyList<Diagonal> _diagonals;

        public GameBoard(IReadOnlyList<IReadOnlyList<Field>> fields, 
               IReadOnlyList<Row> rows, 
               IReadOnlyList<Column> columns, 
               IReadOnlyList<Diagonal> diagonals)
        {
            _fields = fields ?? throw new ArgumentNullException(nameof(fields));
            _rows = rows ?? throw new ArgumentNullException(nameof(rows));
            _columns = columns ?? throw new ArgumentNullException(nameof(columns));
            _diagonals = diagonals ?? throw new ArgumentNullException(nameof(diagonals));
        }

        public IReadOnlyList<IReadOnlyList<Field>> Fields => _fields;
        public IReadOnlyList<Row> Rows => _rows;
        public IReadOnlyList<Column> Columns => _columns;
        public IReadOnlyList<Diagonal> Diagonals => _diagonals;
    }
}