using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Color = VierGewinnt.Core.Color;
using MSColor = System.Windows.Media.Color;
using VierGewinnt.WpfClient.Converter;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class ColorConverterTests
    {
        [TestMethod]
        public void ColorConverterReturnsColorWithRgbColor()
        {
            var color = new Color(255,128,0);
            var testTarget = new VierGewinntColorConverter();

            var resultingBrush = (SolidColorBrush) testTarget.Convert(color, null, null, null);
            var expectedColor = MSColor.FromRgb(color.Red, color.Green, color.Blue);

            Assert.AreEqual(expectedColor, resultingBrush.Color);
        }
    }
}
