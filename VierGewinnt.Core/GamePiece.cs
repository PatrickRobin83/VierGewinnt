using System;

namespace VierGewinnt.Core
{
    public class GamePiece
    {
        private readonly Color _color;
        private readonly string _playerName;

        public GamePiece(Color color, string playerName)
        {
            if (color == null) throw new ArgumentNullException("color");
            if (playerName == null) throw new ArgumentNullException("playerName");

            _color = color;
            _playerName = playerName;
        }

        public Color Color
        {
            get { return _color; }
        }

        public string PlayerName
        {
            get { return _playerName; }
        }

    }
}