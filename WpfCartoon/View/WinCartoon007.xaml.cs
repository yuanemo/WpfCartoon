using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;

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
