namespace VierGewinnt.Core
{
    public class Color
    {
        private readonly byte _red;
        private  readonly byte _green;
        private readonly byte _blue;

        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public byte Red => _red;

        public byte Green => _green;

        public byte Blue => _blue;
    }
}