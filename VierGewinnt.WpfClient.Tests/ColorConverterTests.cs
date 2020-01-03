using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media;
using Color = VierGewinnt.Core.Color;
using MSColor = System.Windows.Media.Color;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class ColorConverterTests
    {
        [TestMethod]
        public void ColorConverterReturnsColorWithRgbColor()
        {
            var color = new Color(255,128,0);
            var testTarget = new ColorConverter();

            var resultingBrush = (SolidColorBrush) testTarget.Convert(color, null, null, null);
            var expectedColor = MSColor.FromRgb(color.Red, color.Green, color.Blue);

            Assert.AreEqual(expectedColor, resultingBrush.Color);
        }
    }
}
