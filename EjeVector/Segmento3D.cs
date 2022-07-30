using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Segmento3D:Vector3D
    {

        public double xf { get; set; }
        public double yf { get; set; }
        public double zf { get; set; }

        public Segmento3D()
        {

        }

        public override void Encender(Bitmap pixel)
        {
            double t = 0;
            double dt = 0.001;
            Vector3D v3D = new Vector3D(0, 0, 0, color0); 

            do
            {
                v3D.x0 = x0 * (1 - t) + (xf * t);
                v3D.y0 = y0 * (1 - t) + (yf * t);
                v3D.z0 = z0 * (1 - t) + (zf * t);
                v3D.Encender(pixel);
                t = t + dt;

            }
            while (t <= 1);

        }

    }
}
