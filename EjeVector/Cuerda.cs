using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Cuerda: Vector
    {
        public int l = 5;
        public double c = 1;
        public double t;
        public Cuerda()
        {

        }
        public void GraficoC(Bitmap lienzo)
        {
            Vector v = new Vector();
            double x = 0;
            do
            {
                v.x0 = x;
                Fourier(x, out double sol);
                v.y0 = sol;
                v.color0 = Color.Red;
                v.Encender(lienzo);
                x = x + 0.002;

            } while (x <= l);

        }
        public void Fourier2(double x, out double sol)
        {
            //
            //double c;
            //Variables
            double ak, bk, sum;
            int k;
            k = 1;
            sum = 0;
            do
            {
                //bk = (2 / k * Math.PI * c) * (l / 6) * (g(0) * Math.Sin((k * Math.PI * 0) / l) + 4 * g(l / 2) * Math.Sin(k * Math.PI / 2) + g(l) * Math.Sin(k * Math.PI));
                //ak = (2 / l) * (l / 6) * (f(0) * Math.Sin((k * Math.PI * 0) / l) + 4 * f(l / 2) * Math.Sin(k * Math.PI / 2) + f(l) * Math.Sin(k * Math.PI));
                //sum = sum + (ak * Math.Cos((k * Math.PI * c * t) / l) + bk*Math.Sin((k*Math.PI*c*t)/l))*Math.Sin((k*Math.PI*x)/l);
                //k = k + 1;
                ak = (l / 6) * (0 + 4 * 1.78 * Math.Sin((k * 3.14) / 2) + 0 * Math.Sin(k * 3.14));
                ak = (2 / l) * ak;
                bk = (l / 6) * (0 + 4 * 1 * Math.Sin((k * 3.14) / 2) + 1 * Math.Sin(k * 3.14));
                bk = (2 / (k * 3.14 * c)) * bk;
                sum = sum + (ak * Math.Cos((k * 3.14 * t * c) / l) + bk * Math.Sin((k * 3.14 * t * c) / l)) * Math.Sin((k * 3.14 * x) / l);
                k = k + 1;
            } while (k <= 25);
            //return sum;
            sol = sum;
        }
        public void Fourier(double x, out double sol)
        {
            double ak, bk, sum = 0;
            int k = 1;
            double c = 1;
            double l = 5;
            //Definición de funciones F y G
            double f = (-x * (x - l)) / 50;
            double g = 1;


            do
            {
                ak = (l / 6) * (0 + 4 * f * Math.Sin((k * Math.PI) / 2));
                ak = (2 / l) * ak;

                bk = (l / 6) * (0 + 4 * g * Math.Sin((k * Math.PI) / 2));
                bk = (2 / (k * Math.PI * c)) * bk;

                sum = sum + (ak * Math.Cos((k * Math.PI * t * c) / l) + bk * Math.Sin((k * Math.PI * t * c) / l)) * Math.Sin((k * Math.PI * x) / l);
                k = k + 1;

            } while (k <= 25);

            sol = sum;
        }

    }
}
