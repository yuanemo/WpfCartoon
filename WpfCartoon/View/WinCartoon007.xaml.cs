﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon007.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon007 : Window
    {
        public WinCartoon007()
        {
            InitializeComponent();
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            this.GeometryText.Clip = this.MyEllipseGeometry;
        }
    }
}
