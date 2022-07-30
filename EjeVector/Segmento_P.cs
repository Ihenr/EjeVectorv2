using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Segmento_P:Vector
    {
        double t = 0;
        double dt = 0.001;

        public double xf { get; set; }
        public double yf { get; set; }

        public Segmento_P()
        {

        }
        public override void Encender(Bitmap pixel)
        {
            double t = 0;
            double dt = 0.001;

            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = x0 * (1 - t) + xf * t;
                v.y0 = y0 * (1 - t) + yf * t;
                v.color0 = Color.FromArgb(255, (int)(255 * (t) / 1), 0, (int)(255 * (t - 1) / -1)); 
                v.Encender(pixel);
                t = t + dt;

            }
            while (t <= 1);

        }

    }
}
