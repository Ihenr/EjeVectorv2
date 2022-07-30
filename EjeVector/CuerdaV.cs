using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class CuerdaV: Vector
    {
        
        public double t;
        public Color c;
        public CuerdaV()
        {

        }
        ~CuerdaV()
        { }
        public void Fourier(double x, out double fou)
        {
            double an, bn, sumF, c;
            c = 1;
            int n = 0;
            sumF = 0;
            double f = ((-x * (x - 8)) / 3);//x=4 5.33   x=8  0
            double g = x;
            do
            {
                n = n + 1;

                an = (1.33) * (0 + 4 * 5.33 * Math.Sin(n * 3.14 * 3) + 0 * Math.Sin(n * 3.14 * 6));
                an = an * (0.25);
                bn = (1.33) * (0 + 4 * 4 * Math.Sin(n * 3.14 * 3) + 8 * Math.Sin(n * 3.14));
                bn = bn * (2 / (n * 3.14 * 1));
                sumF = sumF + (an * Math.Cos((n * 3.14 * t) / 8) + bn * Math.Sin((n * 3.14 * t) / 8)) * Math.Sin(n * 3.14 * x / 8);

            } while (n <= 20);

            fou = sumF;

        }

        public void Grafico(Bitmap pantalla)
        {
            double x = 0;
            Vector vec = new Vector();
            vec.color0 = Color.Red;
            do
            {
                vec.x0 = x;
                Fourier(x, out double fou);
                vec.y0 = fou;
                vec.Encender(pantalla);
                x += 0.01;
            } while (x <= 6);
        }
    }
}
