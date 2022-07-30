using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Lazo:Circunferencia
    {
        public override void Encender(Bitmap pixel)
        {
            double t = 0;
            double dt = 0.001;
            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = x0 + Rd * Math.Cos(2*t);
                v.y0 = y0 + Rd * Math.Sin(3*t);
                v.Encender(pixel);
                t = t + dt;
            } while (t <= 3 * (Math.PI));
        }
    }
}
