namespace VierGewinnt.Core.Tests
{
    public class ColumnMock : IColumn
    {
        private int _countPlayTurnCalls;
        public void DropGamePiece(GamePiece gamePiece)
        {
            _countPlayTurnCalls++;
        }

        public bool IsDropGamePieceCalledOnce
        {
            get { return _countPlayTurnCalls == 1; }
        }
    }
}
