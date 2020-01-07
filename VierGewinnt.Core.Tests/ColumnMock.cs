using System;

namespace VierGewinnt.Core.Tests
{
    public class ColumnMock : IColumn
    {
        private int _countPlayTurnCalls;
        private IColumn _columnImplementation;
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

        public int Index => _columnImplementation.Index;

        public bool IsDropGamePieceCalledOnce
        {
            get { return _countPlayTurnCalls == 1; }
        }
    }
}
