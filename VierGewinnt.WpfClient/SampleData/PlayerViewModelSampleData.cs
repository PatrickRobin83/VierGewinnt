using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class PlayerViewModelSampleData : IPlayerViewModel
    {
        private readonly Player _samplePlayer;

        public PlayerViewModelSampleData()
        {
            var gamePieces = new List<GamePiece>();
            var playerColor = new Color(0,0,128);
            const string playerName = "SamplePlayer A";
           
            for (int i = 0; i < 21; i++)
            {
                gamePieces.Add(new GamePiece(playerColor,playerName));
            }
            _samplePlayer = new Player(playerName, gamePieces, playerColor);
            ItsPlayersTurn = true;
        }

        public Player Player => _samplePlayer;

        public bool ItsPlayersTurn { get; set; }
    }
}
