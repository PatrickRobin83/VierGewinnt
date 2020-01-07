using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core
{
    public class Column : Line, IColumn
    {
        private readonly IReadOnlyList<IField> _fields;
        private readonly int _index;
        private bool _isColumnFull;

        public Column(int index,IReadOnlyList<IField> fields) : base(fields)
        {
            _index = index;
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
            set => _isColumnFull = value;
        }

        public int Index => _index;

    }
}