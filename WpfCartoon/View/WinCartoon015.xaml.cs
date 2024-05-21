using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon015.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon015 : Window
    {
        public WinCartoon015()
        {
            InitializeComponent();
            List<BitmapImage> ls_adv_img = new List<BitmapImage>();
            List<string> listAdv = GetUserImages(@"C:\Image");
            foreach (string a in listAdv)
            {
                BitmapImage img = new BitmapImage(new Uri(a));
                ls_adv_img.Add(img);
            }
            this.rollImg.ls_images = ls_adv_img;
            this.rollImg.Begin();
        }

        /// <summary>
        /// 获取当前用户的图片文件夹中的图片路径列表(不包含子文件夹)
        /// </summary>
        private List<string> GetUserImages(string path)
        {
            List<string> images = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = GetPicFiles(path, "*.jpg,*.png,*.bmp,", SearchOption.TopDirectoryOnly);

            if (files != null)
            {
                foreach (FileInfo file in files)
                {
                    images.Add(file.FullName);
                }
            }
            return images;
        }

        private FileInfo[] GetPicFiles(string picPath, string searchPattern, SearchOption searchOption)
        {
            List<FileInfo> ltList = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(picPath);
            string[] sPattern = searchPattern.Replace(';', ',').Split(',');
            for (int i = 0; i < sPattern.Length; i++)
            {
                FileInfo[] files = null;
                try
                {
                    files = dir.GetFiles(sPattern[i], searchOption);
                }
                catch (System.Exception ex)
                {
                    files = new FileInfo[] { };
                }

                ltList.AddRange(files);
            }
            return ltList.ToArray();
        }
    }
}
