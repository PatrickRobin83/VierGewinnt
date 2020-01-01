using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core
{
    public class Column : Line, IColumn
    {
        private readonly IReadOnlyList<Field> _fields;

        public Column(IReadOnlyList<Field> fields) : base(fields)
        {

        }

        public void DropGamePiece(GamePiece gamePiece)
        {
            foreach (var field in Fields)
            {
                if (field.GamePiece == null)
                {
                    field.GamePiece = gamePiece;
                    return;
                }
            }
            throw new InvalidOperationException("Column is already full");
        }

        public bool IsColumnFull
        {
            get { return Fields.All(field => field.GamePiece != null); }
        }

    }
}