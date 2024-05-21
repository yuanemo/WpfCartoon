using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using WpfCartoon.UC;

namespace WpfCartoon.View
{
    /// <summary>
    /// winCartoon001.xaml 的交互逻辑
    /// </summary>
    public partial class winCartoon001 : Window
    {
        public winCartoon001()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UCRingControl redRing = new UCRingControl
            {
                MinSize = 25,
                MaxSize = 100,
                EllipseNum = 4,
                EllipseInterval = 800,
                AnimationDuration = 5,
                EllipseStroke = new SolidColorBrush(Colors.Red),
                EllipseStrokeThickness = 25,
                Margin = new Thickness(-150, -300, 0, 0),
            };
            this.mainGrid.Children.Add(redRing);

            UCRingControl blueRing = new UCRingControl
            {
                MinSize = 25,
                MaxSize = 100,
                EllipseNum = 4,
                EllipseInterval = 800,
                AnimationDuration = 5,
                EllipseStroke = new SolidColorBrush(Colors.Blue),
                EllipseStrokeThickness = 25,
                Margin = new Thickness(-200, 300, 0, 0),
            };
            this.mainGrid.Children.Add(blueRing);

            UCRingControl greenRing = new UCRingControl
            {
                MinSize = 25,
                MaxSize = 100,
                EllipseNum = 4,
                EllipseInterval = 800,
                AnimationDuration = 5,
                EllipseStroke = new SolidColorBrush(Colors.Green),
                EllipseStrokeThickness = 25,
                Margin = new Thickness(200, 20, 0, 0),
            };
            this.mainGrid.Children.Add(greenRing);
        }
    }
}
