using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Lazo_P:Circunferencia
    {
        public override void Encender(Bitmap pixel)
        {
            double t = 0;
            double dt = 0.001;
            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = x0 + Rd * Math.Cos(2 * t);
                v.y0 = y0 + Rd * Math.Sin(3 * t);
                //v.color0 = Color.FromArgb(255, (int)((((200*(t-1.5*Math.PI))/-1.5*Math.PI))+(210*t/1.5*Math.PI)), (int)((((150 * (t - 1.5 * Math.PI)) / -1.5 * Math.PI)) + (80 * t / 1.5 * Math.PI)),(int)((50*t/1.5*Math.PI)));
                  v.color0 = Color.FromArgb(255, (int)((200 * (t - (1.5 * Math.PI)) / (-1.5 * Math.PI)) + ((210 * t) / (1.5 * Math.PI))), (int)(((150 * (t - (1.5 * Math.PI))) / (-1.5 * Math.PI)) + ((80 * t) / (1.5 * Math.PI))), (int)((50 * t) / (1.5 * Math.PI)));
                v.Encender(pixel);
                t = t + dt;
            } while (t <= 3 * (Math.PI));
        }
    }
}
