﻿using System;
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
using System.Windows.Threading;
using WpfCartoon.Model;

namespace WpfCartoon.View
{
    /// <summary>
    /// WinCartoon013.xaml 的交互逻辑
    /// </summary>
    public partial class WinCartoon013 : Window
    {
        public WinCartoon013()
        {
            InitializeComponent();
            _frameTimer = new DispatcherTimer();
            _frameTimer.Tick += OnFrame;
            _frameTimer.Interval = TimeSpan.FromSeconds(1.0 / 60.0);
            _frameTimer.Start();

            _ps = new ParticleSystem013(50, 50, Colors.White, 30);

            WorldModels.Children.Add(_ps.ParticleModel);

            _ps.SpawnParticle(30);

            KeyDown += Window_KeyDown;
            Cursor = Cursors.None;
        }

        private readonly ParticleSystem013 _ps;
        private DispatcherTimer _frameTimer;


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private void OnFrame(object sender, EventArgs e)
        {
            _ps.Update();
        }
    }


}
