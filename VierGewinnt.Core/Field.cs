using System;
using VierGewinnt.Core.Interfaces;

namespace VierGewinnt.Core
{
    public class Field : IField
    {
        private readonly int _x;
        private readonly int _y;

        public Field(int x, int y)
        {
            if (x < 0) throw new ArgumentOutOfRangeException(nameof(x), "Column index was out of range. Must be non-negative");
            if (y < 0) throw new ArgumentOutOfRangeException(nameof(y), "Row index was out of range. Must be non-negative");
            _x = x;
            _y = y;
        }
        public GamePiece GamePiece { get; set; }

        public int X => _x;

        public int Y => _y;

        public override string ToString()
        {
            return $"Platz {_x}, {_y}";
        }
    }
}