using System;
using System.Collections.Generic;
using VierGewinnt.Core.Interfaces;

namespace VierGewinnt.Core.Tests
{
    public class ColumnMock : IColumn
    {
        private int _countPlayTurnCalls;
        private bool _isColumnFull;


        public void DropGamePiece(GamePiece gamePiece)
        {
            _countPlayTurnCalls++;
        }

        public bool IsColumnFull
        {
            get { return _isColumnFull; }
            set => _isColumnFull = value;
        }

        public int Index => 5;

        public bool IsDropGamePieceCalledOnce
        {
            get { return _countPlayTurnCalls == 1; }
        }
    }
}
