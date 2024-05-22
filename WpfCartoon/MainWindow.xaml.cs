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

        private void bth09_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon009  winCartoon009 = new WinCartoon009();
            winCartoon009.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bth10_Click(object sender, RoutedEventArgs e)
        {
            ///思路：使用自定义控件，
            ///设置一个背板 MyCardControlBottom，
            ///一个卡牌翻动的前部 MyCardControlFront，
            ///一个卡牌翻动后的背部 MyCardControlBack，
            ///另外实现卡牌翻动的MyCardControl；
            ///在主窗体中设置一计时器，根据卡牌上的数字和计时器时间启动翻牌动作。
            ///

            WinCartoon010 winCartoon010 = new WinCartoon010();
            winCartoon010.Show();
        }

        private void bth11_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon011 winCartoon011 = new WinCartoon011();
            winCartoon011.Show();
        }

        private void bth12_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon012 winCartoon012 = new WinCartoon012();
            winCartoon012.Show();
        }

        private void bth13_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon013 winCartoon013 = new WinCartoon013();
            winCartoon013.Show();
        }

        private void bth14_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon014  winCartoon014 = new WinCartoon014();
            winCartoon014.Show();
        }

        private void bth15_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon015 winCartoon015 = new WinCartoon015();
            winCartoon015.Show();
        }

        private void bth16_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon016 winCartoon016 = new WinCartoon016();
            winCartoon016.Show();
        }

        private void bth17_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon017 winCartoon017 = new WinCartoon017();
            winCartoon017.Show();
        }

        private void bth18_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon018  winCartoon018 = new WinCartoon018();
            winCartoon018.Show();
        }

        private void bth19_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon019 winCartoon019 = new WinCartoon019();
            winCartoon019.Show();
        }

        private void bth20_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon020 winCartoon020 = new WinCartoon020();
            winCartoon020.Show();
        }

        private void bth21_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon021 winCartoon021 = new WinCartoon021();
            winCartoon021.Show();
        }

        private void bth22_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon022 winCartoon022 = new WinCartoon022();
            winCartoon022.Show();
        }

        private void bth23_Click(object sender, RoutedEventArgs e)
        {
            WinCartoon023 winCartoon023 = new WinCartoon023();
            winCartoon023.Show();
        }

        private void bth24_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bth25_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bth26_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bth27_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
