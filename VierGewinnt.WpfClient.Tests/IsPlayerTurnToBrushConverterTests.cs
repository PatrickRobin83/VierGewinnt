using System;
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class IsPlayerTurnToBrushConverterTests
    {
        private ItsPlayersTurnToBrushConverter _testTarget;

        [TestInitialize]
        public void TestInitialize()
        {
            _testTarget = new ItsPlayersTurnToBrushConverter();
            
        }
        [TestMethod]
        public void ConverterReturnsTransparentBrushIfValueFalse()
        {
            var brush = (SolidColorBrush)_testTarget.Convert(false, null, null, null);

            Assert.AreEqual(Colors.Transparent,brush.Color);
        }

        [TestMethod]
        public void ConverterReturnsSilverBrushIfValueTrue()
        {
            var brush = (SolidColorBrush)_testTarget.Convert(true, null, null, null);

            Assert.AreEqual(Colors.Silver, brush.Color);
        }
    }
}
