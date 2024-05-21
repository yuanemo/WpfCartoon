using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon020.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon020 : Window
    {
        public WinCartoon020()
        {
            InitializeComponent();
        }

        private Point pointBefore;

        private void MyViewport3D_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pointBefore = e.GetPosition(this);
        }

        private void MyViewport3D_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point pointAfter = e.GetPosition(this);
                var moveX = pointAfter.X - pointBefore.X;
                var moveY = pointAfter.Y - pointBefore.Y;
                Vector3D axis = new Vector3D(moveX, moveY, 1);
                AxisAngleRotation3D aar = this.FindName("myRotate") as AxisAngleRotation3D;
                aar.Axis = axis;
                aar.Angle = moveX;
            }
        }
    }
}
