using System;

namespace OOP_lab1.Structs
{
    public struct PixelColor
    {
        public byte red;
        public byte green;
        public byte blue;
        public byte alpha;

        public byte[] Core => new byte[] { blue, green, red, alpha };

        public PixelColor(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public PixelColor(string hex)
        {
            if (hex.Length != 6) hex = "ffffff";

            red = byte.Parse(hex[0..2], System.Globalization.NumberStyles.HexNumber);
            green = byte.Parse(hex[2..4], System.Globalization.NumberStyles.HexNumber);
            blue = byte.Parse(hex[4..6], System.Globalization.NumberStyles.HexNumber);
            alpha = 255;
        }
    }

    public static class PixelColors
    {
        public static PixelColor Black => new(0, 0, 0, 255);
        public static PixelColor Red => new(255, 0, 0, 255);
        public static PixelColor Green => new(0, 255, 0, 255);
        public static PixelColor Blue => new(0, 0, 255, 255);
        public static PixelColor White => new(255, 255, 255, 255);
    }
}
