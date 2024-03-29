﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfCartoon.Model
{
    /// <summary>
    /// 粒子类
    /// </summary>
    public class Particle
    {
        public double Decay;//消散系数
        public double Life; //存在时长
        public Point Position;//位置
        public double Size;//尺寸
        public double StartLife;//开始时长
        public double StartSize;//开始尺寸
        public Vector Velocity;//位移数
    }
}
