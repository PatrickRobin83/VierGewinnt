using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class PlayerViewModelSampleData : IPlayerViewModel
    {
        private readonly Player _player;

        public PlayerViewModelSampleData()
        {
            var gamePieces = new List<GamePiece>();
            var playerColor = new Color(0,0,128);
            const string playerName = "Player B";
           
            for (int i = 0; i < 21; i++)
            {
                gamePieces.Add(new GamePiece(_player.PlayerColor,_player.Name));
            }
            _player = new Player(playerName, gamePieces, playerColor);
            ItsPlayersTurn = true;
        }
        public Player Player { get; }

        public bool ItsPlayersTurn { get; set; }
    }
}
