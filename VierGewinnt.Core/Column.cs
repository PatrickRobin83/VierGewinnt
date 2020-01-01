using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Column : Line,IColumn
    {
        private readonly IReadOnlyList<Field> _fields;

        public Column(IReadOnlyList<Field> fields) : base(fields)
        {

        }

        public void DropGamePiece(GamePiece gamePiece)
        {
            throw new NotImplementedException();
        }

    }
}