using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Media3D;

namespace WpfCartoon.Model
{
    /// <summary>
    /// 粒子系统管理类
    /// </summary>
    public class ParticleSystemManager
    {
        private readonly Dictionary<Color, ParticleSystem> _particleSystems;

        public ParticleSystemManager()
        {
            _particleSystems = new Dictionary<Color, ParticleSystem>();
        }

        public int ActiveParticleCount => _particleSystems.Values.Sum(ps => ps.Count);

        public void Update(float elapsed)
        {
            foreach (var ps in _particleSystems.Values)
            {
                ps.Update(elapsed);
            }
        }

        //public void SpawnParticle(Point position, double speed, Color color, double size, double life)
        //{
        //    try
        //    {
        //        var ps = _particleSystems[color];
        //        ps.SpawnParticle(position, speed, size, life);
        //    }
        //    catch
        //    {
        //        // ignored
        //    }
        //}

        public Model3D CreateParticleSystem(int maxCount, Color color)
        {
            var ps = new ParticleSystem(maxCount, color);
            _particleSystems.Add(color, ps);
            return ps.ParticleModel;
        }

        public void SpawnParticle(Point position, double speedX, double speedY, Color color, double size, double life)
        {
            try
            {
                var ps = _particleSystems[color];
                ps.SpawnParticle(position, speedX, speedY, size, life);
            }
            catch
            {
                // ignored
            }
        }

        public void Dispose()
        {
            foreach (var ps in _particleSystems.Values)
            {
                ps.Dispose();
            }
        }

    }
}
