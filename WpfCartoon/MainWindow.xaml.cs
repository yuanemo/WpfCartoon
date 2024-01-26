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
    }
}
