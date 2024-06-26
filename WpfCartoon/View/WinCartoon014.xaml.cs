﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon014.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon014 : Window
    {
        public WinCartoon014()
        {
            InitializeComponent();
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            var moveX = (e.GetPosition(this.img).X / this.img.ActualWidth - 0.5) * (-25);
            var moveY = -(e.GetPosition(this.img).Y / this.img.ActualHeight - 0.5) * (-20);

            DoubleAnimation da = new DoubleAnimation();
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            da.To = 10d;
            Vector3D axis = new Vector3D(moveX, moveY, 0);
            AxisAngleRotation3D aar = this.FindName("MyAxisAngleRotation3D") as AxisAngleRotation3D;
            if (aar != null)
            {
                aar.Axis = axis;
                aar.BeginAnimation(AxisAngleRotation3D.AngleProperty, da);
            }
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            da.To = 0d;
            AxisAngleRotation3D aar = this.FindName("MyAxisAngleRotation3D") as AxisAngleRotation3D;
            if (aar != null)
            {
                aar.BeginAnimation(AxisAngleRotation3D.AngleProperty, da);
            }
        }
    }
}
