using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using OOP_lab1.Structs;
using OOP_lab1.Extentions;
using OOP_lab1.Shapes;
using OOP_lab1.Collections;
using Rectangle = OOP_lab1.Shapes.Rectangle;
using Point = OOP_lab1.Structs.Point;
using OOP_lab1.Factory;
using OOP_lab1.Enums;
using System;

namespace OOP_lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private Button _activeBtn;
        private WriteableBitmap _bitmap;
        private Point _rigthPoint, _leftPoint;
        public MainWindow()
        {
            InitializeComponent();

            foreach(var item in Enum.GetValues<ShapesEnum>())
            {
                Button btn = new()
                {
                    Margin = new Thickness(4),
                    Content = item,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Width = 60,
                    Tag = item
                };
                btn.Click += SelectShape;
                toolPanel.Children.Add(btn);
            }

            _bitmap = new(800, 388, 96, 96, PixelFormats.Bgr32, null);
            Palette.Source = _bitmap;
            PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                _activeBtn.IsEnabled = true;
                _activeBtn = null;
            }
        }

        private void Palette_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(_activeBtn == null)
                return;
            else if (_leftPoint == null)
                _leftPoint = new Point(e.GetPosition(Palette));
            else
            {
                _rigthPoint = new Point(e.GetPosition(Palette));

                BaseShape shape = ShapeFactory.Build((ShapesEnum)_activeBtn.Tag, _rigthPoint, _leftPoint);
                shape.ColorOutline = new PixelColor(colorBox.Text);
                shape.LineWidth = int.Parse(widthBox.Text);

                _bitmap.DrawShape(shape);

                _rigthPoint = _leftPoint = null;
            }
        }

        private void SelectShape(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (_activeBtn != null) _activeBtn.IsEnabled = true;
            _activeBtn = button;
            _activeBtn.IsEnabled = false;            
        }
    }
}
