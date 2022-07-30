using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class circunferencia_color:Vector
    {
        public double Radio;
        public override void Encender(Bitmap lienzo)
        {
           
            base.Encender(lienzo);
            double t = 0;
            double dt = 0.001;
            Vector v = new Vector();
            do
            {
                v.x0 = x0 + (Radio * (Math.Cos(t)));
                v.y0 = y0 + (Radio * (Math.Sin(t)));
                //v.color0 = Color.FromArgb(255,((37*(t-Math.PI))/-Math.PI)+((140*(t))/Math.PI),(93*(t-Math.PI)/-Math.PI)+(150*(t)/Math.PI),0);
                v.color0 = Color.FromArgb(255, (int)(((37 * (t - Math.PI)) / -Math.PI) + ((140 * (t)) / Math.PI)), (int)((93 * (t - Math.PI) / -Math.PI) + (150 * (t) / Math.PI)), (int)((140 * (t - Math.PI) / -Math.PI) + (30 * t / Math.PI)));
                //((37*(t-Math.PI))/-Math.PI)+((140*(t))/Math.PI)(140 * (t - Math.PI) / -Math.PI) + (30 * t / Math.PI)
                v.Encender(lienzo);
                t = t + dt;
            } while (t <= Math.PI);

            t = Math.PI;
            do
            {
                v.x0 = x0 + (Radio * (Math.Cos(t)));
                v.y0 = y0 + (Radio * (Math.Sin(t)));
                v.color0 = Color.FromArgb(255, (int)((140 * (t - 2 * Math.PI) / -Math.PI) + (180 * (t - Math.PI) / Math.PI)), (int)((150 * (t - 2 * Math.PI) / -Math.PI) + (50 * (t - Math.PI) / Math.PI)), (int)((30 * (t - 2 * Math.PI) / -Math.PI) + (10 * (t - Math.PI) / Math.PI)));
                v.Encender(lienzo);
                t = t + dt;
            } while (t <= 2 * Math.PI);
        }
    }
}
