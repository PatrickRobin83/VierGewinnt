namespace VierGewinnt.Core.Interfaces
{
        public interface IColumn
        {
            void DropGamePiece(GamePiece gamePiece);
            bool IsColumnFull { get; set; }

            int Index { get; }
        }
}
