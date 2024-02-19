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
    /// UCImageBox.xaml 的交互逻辑
    /// </summary>
    public partial class UCImageBox : UserControl
    {
        #region Property
        public static readonly DependencyProperty DisplayImageProperty = DependencyProperty.Register("DisplayImage", typeof(ImageSource), typeof(UCImageBox), new PropertyMetadata(null));
        public ImageSource DisplayImage
        {
            get { 
                return (ImageSource)GetValue(DisplayImageProperty); 
            }
            set { 
                SetValue(DisplayImageProperty, value); 
            }
        }

        public static readonly DependencyProperty ImageTitleProperty = DependencyProperty.Register("ImageTitle", typeof(String), typeof(UCImageBox), new PropertyMetadata(null));
        public String ImageTitle
        {
            get { 
                return (String)GetValue(ImageTitleProperty); 
            }
            set { 
                SetValue(ImageTitleProperty, value); 
            }
        }
        public double Rotate { set; get; }
        #endregion

        public UCImageBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
