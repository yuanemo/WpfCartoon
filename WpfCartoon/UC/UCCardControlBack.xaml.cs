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
    /// UCCardControlBack.xaml 的交互逻辑
    /// </summary>
    public partial class UCCardControlBack : UserControl
    {

        #region 依赖属性
        public static readonly DependencyProperty BackTextProperty = DependencyProperty.Register("BackText", typeof(string), typeof(UCCardControlBack), new PropertyMetadata(null));
        public string BackText
        {
            get { return (string)GetValue(BackTextProperty); }
            set { SetValue(BackTextProperty, value); }
        }
        #endregion
        public UCCardControlBack()
        {
            InitializeComponent();
        }
    }
}
