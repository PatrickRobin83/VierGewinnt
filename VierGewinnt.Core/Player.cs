using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{

    public partial class Player
    {
        private readonly string _name;
        private readonly IList<GamePiece> _gamePieces;
        private readonly Color _playerColor;

        public Player(string name, IList<GamePiece> gamePieces, Color playerColor)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name),"Whitespaces not allowed in Playername");
            if (gamePieces == null) throw new ArgumentNullException(nameof(gamePieces),"GamePieces shall not null");
            if (playerColor == null) throw new ArgumentNullException(nameof(playerColor), "Color of the Player shall not null");
            _gamePieces = gamePieces;
            _playerColor = playerColor; 
            _name = name;
        }

        public string Name => _name;

        public IList<GamePiece> GamePieces => _gamePieces;

        public Color PlayerColor => _playerColor;

        public void PlayTurn(IColumn column)
        {
            if (column == null) throw new ArgumentNullException("Column");

            var gamePiece = _gamePieces[0];
            _gamePieces.RemoveAt(0);

           column.DropGamePiece(gamePiece);
        }
    }
}
