using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Diagonal : Line
    {
        private readonly int _startIndexX;
        private readonly int _startIndexY;
        private readonly DiagonalDirection _diagonalDirection;

        public Diagonal(int startIndexX,
                        int startIndexY,
                        DiagonalDirection diagonalDirection,
                        IReadOnlyList<Field> fields) : base(fields)
        {
            if (startIndexX < 0) throw new ArgumentOutOfRangeException(nameof(startIndexX), "The StartColumnIndex X for the Diagonal was out of range. Must be non-negative");
            if (startIndexY < 0) throw new ArgumentOutOfRangeException(nameof(startIndexY), "The StartColumnIndex Z for the Diagonal was out of range. Must be non-negative");

            _startIndexX = startIndexX;
            _startIndexY = startIndexY;
            _diagonalDirection = diagonalDirection;
        }

        public int StartIndexX => _startIndexX;

        public int StartIndexY => _startIndexY;

        public DiagonalDirection Direction => _diagonalDirection;
    }
}