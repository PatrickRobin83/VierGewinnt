using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{

    public partial class Player
    {
        private readonly string _name;
        private readonly IList<GamePiece> _gamePieces;

        public Player(string name, IList<GamePiece> gamePieces)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Player Name");
            if (gamePieces == null) throw new ArgumentNullException("GamePieces");

            _gamePieces = gamePieces;
            _name = name;


        }

        public string Name
        {
            get { return _name; }
        }

        public IList<GamePiece> GamePieces
        {
            get { return _gamePieces; }
        }

        public void PlayTurn(IColumn column)
        {
            if (column == null) throw new ArgumentNullException("Column");

            var gamePiece = _gamePieces[0];
            _gamePieces.RemoveAt(0);

           column.DropGamePiece(gamePiece);
        }
    }
}
