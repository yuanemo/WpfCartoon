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
using System.Windows.Shapes;
using WpfCartoon.Model;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon018.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon018 : Window
    {
        public WinCartoon018()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private ParticleSystem018 ps;
        private Point pMouse = new Point(9999, 9999);

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ps = new ParticleSystem018(15, 100, 10, 100, 150, this.cvs_particleContainer, this.grid_lineContainer);
            //注册帧动画
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        /// <summary>
        /// 帧渲染事件
        /// </summary>
        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            ps.ParticleRoamUpdate(pMouse);
            ps.AddOrRemoveParticleLine();
            ps.MoveParticleLine();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            pMouse = e.GetPosition(this.cvs_particleContainer);
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            pMouse = new Point(9999, 9999);
        }
    }
}
