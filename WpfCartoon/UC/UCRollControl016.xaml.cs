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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCartoon.UC
{
    /// <summary>
    /// UCRollControl016.xaml 的交互逻辑
    /// </summary>
    public partial class UCRollControl016 : UserControl
    {
        public UCRollControl016()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var s = (Storyboard)FindResource("RotateStoryboard");
            BeginStoryboard(s);
        }
    }
}
