﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Circunferencia:Vector
    {
        public double Rd;

        public override void Encender(Bitmap pixel)
        {
            double t = 0;
            double dt = 0.001;
            Vector v = new Vector(0, 0, color0);
            do
            {
                v.x0 = x0 + Rd * Math.Cos(t);
                v.y0 = y0 + Rd * Math.Sin(t);
                v.Encender(pixel);
                t = t + dt;

            } while (t <= 2 * (Math.PI));
        }

    }
}
