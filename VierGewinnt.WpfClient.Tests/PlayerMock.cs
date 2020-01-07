using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    public class PlayerMock : IPlayer
    {

        public string Name => "Foo";

        public int CountPlayTurns { get; set; }

        public IList<GamePiece> GamePieces => new List<GamePiece>(21);
        public Color PlayerColor => new Color(128,0,0);

        public void PlayTurn(IColumn column)
        {
            throw new NotImplementedException();
        }
    }
}
