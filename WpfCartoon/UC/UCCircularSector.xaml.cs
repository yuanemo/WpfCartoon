﻿using System;
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

namespace WpfCartoon.UC
{
    /// <summary>
    /// UCCircularSector.xaml 的交互逻辑
    /// </summary>
    public partial class UCCircularSector : UserControl
    {
        public UCCircularSector()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty DisplayImageProperty = DependencyProperty.Register("DisplayImage", typeof(ImageSource), typeof(UCCircularSector), new PropertyMetadata(null));
        public ImageSource DisplayImage
        {
            get { return (ImageSource)GetValue(DisplayImageProperty); }
            set { SetValue(DisplayImageProperty, value); }
        }

        public static readonly DependencyProperty BackgroundColorProperty = DependencyProperty.Register("BackgroundColor", typeof(SolidColorBrush), typeof(UCCircularSector), new PropertyMetadata(null));
        public SolidColorBrush BackgroundColor
        {
            get { return (SolidColorBrush)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        private void MainGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            this.sectorPath.Fill = new SolidColorBrush(Color.FromRgb(246, 111, 111));
        }

        private void MainGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            this.sectorPath.Fill = BackgroundColor;
        }
    }
}
