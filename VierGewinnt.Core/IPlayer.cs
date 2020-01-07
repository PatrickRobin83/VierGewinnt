using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public interface IPlayer
    {
        string Name { get; }
        IList<GamePiece> GamePieces { get; }
        Color PlayerColor { get; }
        void PlayTurn(IColumn column);
    }
}
