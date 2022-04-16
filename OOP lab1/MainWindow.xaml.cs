using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using OOP_lab1.Structs;
using OOP_lab1.Extentions;
using OOP_lab1.Shapes;
using Point = OOP_lab1.Structs.Point;
using OOP_lab1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

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

            IEnumerable<Type> shapesTypes = typeof(BaseShape).Assembly.ExportedTypes.Where(t => typeof(BaseShape).IsAssignableFrom(t) && t != typeof(BaseShape));

            foreach (var item in shapesTypes)
            {
                Button btn = new()
                {
                    Margin = new Thickness(4),
                    Content = item.Name,
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

                BaseShape shape = ShapeFactory.Build((Type)_activeBtn.Tag, _rigthPoint, _leftPoint);
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
