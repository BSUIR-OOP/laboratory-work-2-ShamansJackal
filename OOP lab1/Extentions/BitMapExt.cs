using OOP_lab1.Shapes;
using OOP_lab1.Structs;
using System.Windows;
using System.Windows.Media.Imaging;
using Point = OOP_lab1.Structs.Point;

namespace OOP_lab1.Extentions
{
    public static class BitMapExt
    {
        private static void AddPixel(this WriteableBitmap wb, PixelColor color, int x, int y){
            Int32Rect rect = new(x, y, 1, 1);
            int stride = (wb.PixelWidth * wb.Format.BitsPerPixel) / 8;
            wb.WritePixels(rect, color.Core, stride, 0);
        }

        public static void AddRect(this WriteableBitmap wb, PixelColor color, int x, int y, int size)
        {
            int beg_x = x-size < 0 ? 0 : x - size;
            int beg_y = y-size < 0 ? 0 : y - size;
            int end_x = x+size > wb.PixelWidth ? wb.PixelWidth : x + size;
            int end_y = y+size > wb.PixelHeight ? wb.PixelHeight : y + size;

            for (int i = beg_x; i < end_x; i++)
                for (int j = beg_y; j < end_y; j++)
                    wb.AddPixel(color, i, j);
        }

        public static void DrawShape(this WriteableBitmap wb, BaseShape shape)
        {
            foreach (var curve in shape.Curves)
            {
                for(double i = 0; i < 1; i += 0.005)
                {
                    Point point = curve.Draw(i);
                    wb.AddRect(shape.Color, (int)point.X, (int)point.Y, shape.LineWidth);
                }
            }
        }
    }
}
