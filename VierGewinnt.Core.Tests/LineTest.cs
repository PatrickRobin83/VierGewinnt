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
                new Field(0,0){GamePiece = new GamePiece(new Color(128,0,0), "Foo")},
                new Field(0,1){GamePiece = new GamePiece(new Color(128,0,0), "Foo")},
                new Field(0,2){GamePiece = new GamePiece(new Color(128,0,0), "Foo")},
                new Field(0,3){GamePiece = new GamePiece(new Color(128,0,0), "Foo")}

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
                new Field(0,0) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,1) {GamePiece = new GamePiece(new Color(0, 128, 0), "Bar")},
                new Field(0,2) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,3) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,4) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,5) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,6) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")}
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
                new Field(0,0) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,1) {GamePiece = new GamePiece(new Color(0, 128, 0), "Bar")},
                new Field(0,2) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,3) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,4) {GamePiece = new GamePiece(new Color(128, 0, 0), "Foo")},
                new Field(0,5) ,
                new Field(0,6) 
            };


            var testTarget = new LineDummy(fields);

            var playerName = testTarget.CheckIfPlayerHasFourGamePiecesInARow();

            Assert.IsNull(playerName);
        }
    }
}
