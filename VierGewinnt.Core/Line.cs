using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public abstract class Line
    {
        private readonly IReadOnlyList<IField> _fields;

        protected Line(IReadOnlyList<IField> fields)
        {
            if (fields == null) throw new ArgumentNullException("fields");

            _fields = fields;
        }

        public IReadOnlyList<IField> Fields 
        {
            get { return _fields; }
        }

        public string CheckIfPlayerHasFourGamePiecesInARow()
        {
            var counter = 0;
            string currentPlayerName = null; 

            foreach (var field in _fields)
            {
                var gamePiece = field.GamePiece;
                
                if (gamePiece == null)
                {
                    currentPlayerName = null;
                    counter = 0;
                    continue;
                }
                if (currentPlayerName != gamePiece.PlayerName)
                {
                    currentPlayerName = gamePiece.PlayerName;
                    counter = 1;
                    continue;
                }
                counter++; 
                if(counter >= 4)
                {
                    return currentPlayerName;
                }
            }
            return null;
        }
    }
}
