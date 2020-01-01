namespace VierGewinnt.Core
{
        public interface IColumn
        {
            void DropGamePiece(GamePiece gamePiece);
            bool IsColumnFull { get; }
        }
}
