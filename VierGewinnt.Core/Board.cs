using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Board
    {
        private readonly IReadOnlyList<IReadOnlyList<Field>> _fields;
        private readonly IReadOnlyList<Row> _rows;
        private readonly IReadOnlyList<Column> _columns;

    }
}