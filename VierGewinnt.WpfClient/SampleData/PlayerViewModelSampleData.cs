using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class PlayerViewModelSampleData : IPlayerViewModel
    {
        private readonly Player _player;

        public PlayerViewModelSampleData()
        : this ("Player B", new Color(0,0,128))
        {
            
        }

        public PlayerViewModelSampleData(string playerName, Color playerColor)
        {
            var gamePieces = new List<GamePiece>();
            for (int i = 0; i < 21; i++)
            {
                gamePieces.Add(new GamePiece(playerColor, playerName));
            }
            _player = new Player(playerName, gamePieces, playerColor);
            ItsPlayersTurn = true;
        }

        public Player Player => _player;

        public bool ItsPlayersTurn { get; set; }
    }
}
