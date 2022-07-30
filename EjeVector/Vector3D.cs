using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Vector3D:Vector
    {
        public double z0 = 0;

        public Vector3D() { }
        public Vector3D(double x0, double y0, double z0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.z0 = z0;
            this.color0 = color0;
        }

        public static void axonometria(double x, double y, double z, out double ax, out double ay) 
        {
            ax = y - (x / 2) * (Math.Cos(Math.PI / 4));
            ay = z - (x / 2) * (Math.Sin(Math.PI / 4));
        }

        public override void Encender( Bitmap pixel)
        {
            double ax, ay;
            int Sx, Sy;
            axonometria(x0, y0, z0, out  ax, out ay ) ;
            pantalla(ax, ay, out Sx, out Sy);

            if (Sx > 0 && Sx < 700 && Sy > 0 && Sy < 420)
            {
                pixel.SetPixel(Sx, Sy, color0);

            }

        }
    }
}
