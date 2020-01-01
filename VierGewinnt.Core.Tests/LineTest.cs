using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void FourInARowRecognized()
        {
            
            var fields = new List<Field>
            {
                new Field{GamePiece = new GamePiece(new Color(128,0,0), "Foo")},
                new Field{GamePiece = new GamePiece(new Color(128,0,0), "Foo")},
                new Field{GamePiece = new GamePiece(new Color(128,0,0), "Foo")},
                new Field{GamePiece = new GamePiece(new Color(128,0,0), "Foo")}

            };


            var testTarget = new LineDummy(fields);

            var playerName = testTarget.CheckIfPlayerHasFourGamePiecesInARow();

            Assert.AreEqual("Foo", playerName);
        }

        [TestMethod]
        public void FourGamePiecesInARowWithInterruptionRecognized()
        {
            var fields = new List<Field>
            {
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(0, 128, 0), "Bar")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")}
            };


            var testTarget = new LineDummy(fields);

            var playerName = testTarget.CheckIfPlayerHasFourGamePiecesInARow();

            Assert.AreEqual("Foo", playerName);
        }

        [TestMethod]
        public void NoWinnerIsCorrectRecognized()
        {
            var fields = new List<Field>
            {
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(0, 128, 0), "Bar")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field (),
                new Field ()
            };


            var testTarget = new LineDummy(fields);

            var playerName = testTarget.CheckIfPlayerHasFourGamePiecesInARow();

            Assert.IsNull(playerName);
        }
    }
}
