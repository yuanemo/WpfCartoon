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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCartoon.UC
{
    /// <summary>
    /// UCRoundMenu.xaml 的交互逻辑
    /// </summary>
    public partial class UCRoundMenu : UserControl
    {
        //委托
        public delegate void EventHandle(bool isShow);
        public event EventHandle ShowClickEvent;

        private Storyboard storyboard = new Storyboard();

        public UCRoundMenu()
        {
            InitializeComponent();
            CompositionTarget.Rendering += UpdateEllipse;
        }

        private void UpdateEllipse(object sender, EventArgs e)
        {
            this.sectorCanvas.Clip = this.myEllipseGeometry;
        }

        private void BottomGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (this.bottomTB.Text == "+")
            {
                this.bottomTB.Text = "-";
                Storyboard stbShow = (Storyboard)FindResource("stbShow");
                stbShow.Begin();
                ShowClickEvent?.Invoke(true);
            }
            else
            {
                this.bottomTB.Text = "+";
                Storyboard stbHide = (Storyboard)FindResource("stbHide");
                stbHide.Begin();
                ShowClickEvent?.Invoke(false);
            }
        }
    }
}
