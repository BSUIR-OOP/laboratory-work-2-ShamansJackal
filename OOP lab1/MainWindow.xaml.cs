using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using OOP_lab1.Structs;
using OOP_lab1.Extentions;
using OOP_lab1.Shapes;
using OOP_lab1.Collections;
using Rectangle = OOP_lab1.Shapes.Rectangle;

namespace OOP_lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private WriteableBitmap _bitmap;
        public MainWindow()
        {
            InitializeComponent();
            _bitmap = new(800, 388, 96, 96, PixelFormats.Bgr32, null);
            Palette.Source = _bitmap;
            Button_Click(null, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShapesList shapes = new ShapesList()
            {
                new Rectangle(120, 80, 160, 100) { Color = PixelColors.Blue },
                new Elipse(150, 300, 250, 100),
                new Heart(650, 100, 80) { LineWidth = 6},
                new Square(400, 100, 50) { Color = PixelColors.Green},
                new Triangle(470, 20, 470, 200, 600, 300) {Color = PixelColors.Blue },
                new Circle(400,180,60)
            };

            foreach (var shape in shapes)
            {
                _bitmap.DrawShape(shape);
            }
        }
    }
}
