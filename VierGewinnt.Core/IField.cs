﻿namespace VierGewinnt.Core
{
    public interface IField
    {
        GamePiece GamePiece { get; set; }
        int X { get; }
        int Y { get; }
    }
}