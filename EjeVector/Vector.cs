using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjeVector
{
    internal class Vector
    {
        

        public static int sx1 = 0;
        public static int sx2 = 700;
        public static int sy1 = 0;
        public static int sy2 = 420;
        
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -5.98;        
        public static double y2 = 5.98;
        /*
        public static double x1 = -20;
        public static double x2 = 20;
        public static double y1 = -11.96;
        public static double y2 = 11.96;
        */
        public double x0 { get; set; }
        public double y0 { get; set; }
        public Color color0 { get; set; }
        public Vector() { }
        public Vector(double x0, double y0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }

        public static void pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        public static void VReal(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx1) / (sx1 - sx2)) * (x1 - x2)) + x1;
            y = (((sy - sy1) / (sy1 - sy2)) * (y2 - y1)) + y2;
        }

        public void transforma(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = (((sy - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;
        }
        public void Transforma(int sx, int sy, out double x, out double y)
        {
            x = ((Double)(sx - sx1) / (Double)(sx1 - sx2) * (Double)(x1 - x2)) + x1;
            y = ((Double)(sy - sy1) / (Double)(sy1 - sy2) * (Double)(y2 - y1)) + y2;

        }

        public virtual void Encender(Bitmap pixel)
        {
            int SX;
            int SY;
            pantalla(this.x0, this.y0, out SX, out SY);
            if (SX > 0 && SX < 700 && SY > 0 && SY < 420)
            {
                pixel.SetPixel(SX, SY, color0);
                
            }
        }
        

        public virtual void Apagar(Bitmap pixel)
        {

           
            Vector.pantalla(x0, y0, out int sx, out int sy);

            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 420)
            {
                color0 = Color.White;
                Encender(pixel);

            }



        }

    }
}
