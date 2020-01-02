using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Playertests
    {
        [TestMethod]
        public void PlayTurnRemovesElementFromGamePieces()
        {
            var gamepieces = new List<GamePiece>
            {
                new GamePiece(new Color(128,0,0),"Foo"),
                new GamePiece(new Color(128,0,0), "Foo")
            };
            var testTarget = new Player("Foo", gamepieces, new Color(0,0,255));
            var initialCount = gamepieces.Count;

            testTarget.PlayTurn(new ColumnMock());

            Assert.AreEqual(initialCount -1, testTarget.GamePieces.Count);
        }

        [TestMethod]
        public void PlayTurnDropsGamePiece()
        {
            var gamepieces = new List<GamePiece>
            {
                new GamePiece(new Color(128,0,0),"Foo"),
                new GamePiece(new Color(128,0,0), "Foo")
            };
            var testTarget = new Player("Foo", gamepieces, new Color(0,0,128));
            var columnMock = new ColumnMock();
            testTarget.PlayTurn(columnMock);

            Assert.IsTrue(columnMock.IsDropGamePieceCalledOnce);
        }
    }
}
