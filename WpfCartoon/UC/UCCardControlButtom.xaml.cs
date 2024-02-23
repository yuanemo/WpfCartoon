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

namespace WpfCartoon.UC
{
    /// <summary>
    /// UCCardControlButtom.xaml 的交互逻辑
    /// </summary>
    public partial class UCCardControlButtom : UserControl
    {
        #region 依赖属性
        public static readonly DependencyProperty BottomTextProperty = DependencyProperty.Register("BottomText", typeof(string), typeof(UCCardControlButtom), new PropertyMetadata(null));
        public string BottomText
        {
            get { return (string)GetValue(BottomTextProperty); }
            set { SetValue(BottomTextProperty, value); }
        }
        #endregion
        public UCCardControlButtom()
        {
            InitializeComponent();
        }
    }
}
