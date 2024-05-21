using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WpfCartoon.Model;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon019.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon019 : Window
    {
        public WinCartoon019()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }


        private ParticleSystem019 ps;
        private Point pMouse = new Point(9999, 9999);

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ps = new ParticleSystem019(15, 100, 10, 100, 150, this.cvs_particleContainer, this.grid_lineContainer);
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
