using System.Collections.Generic;

namespace VierGewinnt.Core.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        IList<GamePiece> GamePieces { get; }
        Color PlayerColor { get; }
        void PlayTurn(IColumn column);
    }
}
