﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows;

namespace WpfCartoon.Model
{
    internal class Particle019
    {
        /// <summary>
        /// 形状
        /// </summary>
        public Ellipse Shape;
        /// <summary>
        /// 坐标
        /// </summary>
        public Point Position;
        /// <summary>
        /// 速度
        /// </summary>
        public Vector Velocity;

        /// <summary>
        /// 粒子和线段的集合
        /// </summary>
        public Dictionary<Particle019, Line> ParticleLines;

        /// <summary>
        /// 初始半径
        /// </summary>
        public double DefaultRadius;
    }
}
