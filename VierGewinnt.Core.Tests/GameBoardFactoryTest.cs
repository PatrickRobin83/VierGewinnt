using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class GameBoardFactoryTest
    {
        private GameBoardFactory _testTarget;
        private GameBoard _gameBoard;

        [TestInitialize]
        public void TestInitialize()
        {
            _testTarget = new GameBoardFactory();
            _gameBoard = _testTarget.Create(6, 7);

        }
        [TestMethod]
        public void CreateCreatesCorrectAmountOfColumns()
        {
            
            Assert.AreEqual(7, _gameBoard.Columns.Count);
        }

        [TestMethod]
        public void CreateCreatesCorrectAmountOfRows()
        {
            Assert.AreEqual(6, _gameBoard.Rows.Count);
        }

        [TestMethod]
        public void CreateCreatesCorrectAmountOfFieldsInAColumn()
        {
            var column3 = _gameBoard.Columns[2];

            Assert.IsTrue(column3.Fields.All(field => field.X == 2));
        }

        [TestMethod]
        public void CreateCreatesCorrectAmountOfFieldsInARow()
        {
            var row4 = _gameBoard.Rows[3];

            Assert.IsTrue(row4.Fields.All(field => field.Y == 3));
        }

        [TestMethod]
        public void CreateCreatesCorrectAmountOfFieldsInADiagonalBottomLeft()
        {
            var targetDiagonal = _gameBoard.Diagonals.First(diagonal => diagonal.Direction == DiagonalDirection.LeftBottom &&
                                                                          diagonal.StartIndexX == 5 &&
                                                                          diagonal.StartIndexY == 0);
            var firstField = targetDiagonal.Fields.First();
            var lastField = targetDiagonal.Fields.Last();

            Assert.IsTrue(firstField.X == 5 && firstField.Y == 0);
            Assert.IsTrue(lastField.X == 0 && lastField.Y == 5);
        }

        [TestMethod]
        public void CreateCreatesCorrectAmountOfFieldsInADiagonalBottomRight()
        {
            var targetDiagonal = _gameBoard.Diagonals.First(diagonal =>
                                                            diagonal.Direction == DiagonalDirection.RightBottom &&
                                                            diagonal.StartIndexX == 0 &&
                                                            diagonal.StartIndexY == 2);

            var firstField = targetDiagonal.Fields.First();
            var lastField = targetDiagonal.Fields.Last();

            Assert.IsTrue(firstField.X == 0 && firstField.Y == 2);
            Assert.IsTrue(lastField.X == 3 && lastField.Y == 5);
        }

        [TestMethod]
        public void CreateIgnoresDigonalWithLessThenFourFields()
        {
            Assert.IsTrue(_gameBoard.Diagonals.All(diagonals => diagonals.Fields.Count >= 4));
        }
    }
}
