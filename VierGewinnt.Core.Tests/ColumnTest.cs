using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class ColumnTest
    {
        [TestMethod]
        public void GamePieceDroppedCorrectlyInColumn()
        {
            var fields = new List<Field>();
            for (int i = 0; i < 6; i++)
            {
                fields.Add(new Field(0,i));
            }

            var testTarget = new Column(1,fields);
            var gamePiece = new GamePiece(new Color(128,0,0),"Foo");

            testTarget.DropGamePiece(gamePiece);

            for (int i = 0; i < fields.Count; i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(gamePiece, fields[0].GamePiece);
                    continue;
                }

                Assert.IsNull(fields[i].GamePiece);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GamePieceDropRaiseExceptionIfColumnFull()
        {
            var gamePiece = new GamePiece(new Color(128, 0, 0), "Foo");
            var fields = new List<Field>();
            for (int i = 0; i < 6; i++)
            {
                fields.Add(new Field(0,i){GamePiece = gamePiece});
            }

            var testTarget = new Column(0,fields);
            

            testTarget.DropGamePiece(gamePiece);
        }

        [TestMethod]
        public void IsColumnReturnsFalseIfNotAllFieldsLoaded()
        {
            var fields = new List<Field>();
            var gamePiece = new GamePiece(new Color(128, 0, 0), "Foo");
            for (int i = 0; i < 6; i++)
            {
                fields.Add(new Field(0,i));
            }
            fields[0].GamePiece = gamePiece;
            fields[1].GamePiece = gamePiece;

            var testTarget = new Column(0,fields);
            
            Assert.IsFalse(testTarget.IsColumnFull);
        }

        [TestMethod]
        public void IsColumnFullReturnsTrueIfAllFieldsLoaded()
        {
            var gamePiece = new GamePiece(new Color(128, 0, 0), "Foo");
            var fields = new List<Field>();
            for (int i = 0; i < 6; i++)
            {
                fields.Add(new Field(0,i) { GamePiece = gamePiece });
            }
            var testTarget = new Column(0,fields);

            Assert.IsTrue(testTarget.IsColumnFull);
        }
    }
}
