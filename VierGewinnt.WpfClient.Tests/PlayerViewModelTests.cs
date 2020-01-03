using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class PlayerViewModelTests
    {
        [TestMethod]
        public void ViewModelSendsMessageByChangingValueItsPlayersTurn()
        {
            var testTarget = new PlayerViewModel(new Player("Foo",new List<GamePiece>(),new Color(0,0,0) ));
            var callCount = 0;

            testTarget.PropertyChanged += (sender, args) => callCount++;
            testTarget.ItsPlayersTurn = !testTarget.ItsPlayersTurn;

            Assert.AreEqual(1, callCount);

        }
    }
}
