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
using WpfCartoon.View;

namespace WpfCartoon
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 01 地震波预警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bth01_Click(object sender, RoutedEventArgs e)
        {
            winCartoon001 winCartoon001 = new winCartoon001();
            winCartoon001.Show();
        }

        /// <summary>
        /// 02 load条循环滚动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bth02_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon002 winCartoon002 = new WinCartoon002();
            winCartoon002.Show();
        }

        private void bth03_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon003 winCartoon003 = new WinCartoon003();
            winCartoon003.Show();
        }

        private void bth04_Click(object sender, RoutedEventArgs e)
        {
            WinCarToon004 winCarToon004 = new WinCarToon004();
            winCarToon004.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bth05_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon005 winCartoon005 = new WinCartoon005();
            winCartoon005.Show();
        }

        private void bth06_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon006 winCartoon006 = new WinCartoon006();
            winCartoon006.Show();
        }

        private void bth07_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon007 winCartoon007 = new WinCartoon007();
            winCartoon007.Show();
        }

        private void bth08_Click(object sender, RoutedEventArgs e)
        {
            ///思路:该效果用到了鼠标跟随获取坐标位置，
            ///根据位置信息设置展示图像的Clip属性EllipseGeometry；
            ///同时在进入进出时添加放大缩小动作。
            ///
            WinCartoon008 winCartoon008 = new WinCartoon008();
            winCartoon008.Show();
        }
    }
}
