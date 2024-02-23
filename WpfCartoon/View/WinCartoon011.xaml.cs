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
    /// WinCartoon011.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon011 : Window
    {

        List<ExpanderClass> itemList;
        public WinCartoon011()
        {
            InitializeComponent();
            itemList = new List<ExpanderClass>();
            itemList.Add(new ExpanderClass("1", "/Images/img1.png"));
            itemList.Add(new ExpanderClass("2", "/Images/img2.png"));
            itemList.Add(new ExpanderClass("3", "/Images/img3.png"));
            itemList.Add(new ExpanderClass("4", "/Images/img4.png"));
            itemList.Add(new ExpanderClass("5", "/Images/img5.png"));
            itemList.Add(new ExpanderClass("6", "/Images/img6.png"));
            this.ExpanderItemBox.ItemsSource = itemList;
        }

    }
}
