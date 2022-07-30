using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeVector
{
    internal class Onda : Vector
    {

        public double t;
        public int color;
        public Color c;
        public double v, w, w1, w2, x, y, z, z1, z2, z3, m = 0.6;

        public Color[] paleta1 = new Color[16];
        public Color[] Paleta2 = new Color[16];
        public Color[] Paleta3 = new Color[16];
        public Color[] Paleta4 = new Color[16];
        public Onda()
        {
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            Paleta2[0] = Color.Black;
            Paleta2[1] = Color.Red;
            Paleta2[2] = Color.Green;
            Paleta2[3] = Color.Aqua;
            Paleta2[4] = Color.Navy;
            Paleta2[5] = Color.Purple;
            Paleta2[6] = Color.Maroon;
            Paleta2[7] = Color.LightGray;
            Paleta2[8] = Color.DarkGray;
            Paleta2[9] = Color.Blue;
            Paleta2[10] = Color.Lime;
            Paleta2[11] = Color.Silver;
            Paleta2[12] = Color.Yellow;
            Paleta2[13] = Color.Fuchsia;
            Paleta2[14] = Color.Teal;
            Paleta2[15] = Color.White;



            for (int i = 0; i < 16; i++)
            {
                Paleta3[i] = Color.FromArgb(255, 0, (int)(-1.33 * (i - 15) + 17 * i), (int)(15) * i + 30);

            }

            for (int i = 0; i < 16; i++)
            {
                Paleta4[i] = Color.FromArgb(255, (int)(255 * i / 15), (int)(255 * i / 15),(int)((255 * (i - 15)) / -15));

            }


        }
        public void graf(Bitmap pantalla)
        {
            double aux;
            Vector ov = new Vector();
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    transforma(i, j, out x, out y);
                    aux = w * (Math.Sqrt(x * x + y * y)) - v * t;
                    z = Math.Sin(aux) + 1; //m * Math.Sin(z);  //Math.Sin(aux) + 1;
                    color = (int)(z * 7.5);
                    c = Paleta4[color];
                    pantalla.SetPixel(i, j, c);
                    Encender(pantalla);
                }
            }
        }
        public void GrafOnda3D(Bitmap lienzo)
        {

            Vector3D v3d = new Vector3D();
            x = -8;
            do
            {
                y = -5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    z = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0))) - v * t;
                    z = m * Math.Sin(z);
                    v3d.z0 = z;
                    v3d.color0 = Color.Green;
                    v3d.Encender(lienzo);
                    y = y + 0.1;
                } while (y <= 5);
                x = x + 0.1;
            } while (x <= 8);
        }
        public void Interferencia(Bitmap lienzo)
        {
            int i, j, colorO;
            double x, y, z, z1, z2,z3, w, m, v;
            Color c;
            w = 1.5;
            m = 1; 
            v = 9.3;
            double x1 = 0;
            double y1 = 2;
            double x2 = 0;
            double y2 = -6;
            procesoTercerPunto(x1, y1,x2, y2, out double x3, out double y3);

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 420; j++)
                {
                    transforma(i, j, out x, out y);

                    
                    //z1 = w * (Math.Sqrt((x - 5) * (x - 5) + (y -0) * (y -0)) - v * t);
                    //z2 = w * (Math.Sqrt((x +5) * (x +5) + (y + 0) * (y + 0)) - v * t);
                    // PRUEBA 
                    z1 = w * (Math.Sqrt((x - 0) * (x - 0) + (y + 2) * (y + 2)) - v * t);
                    z2 = w * (Math.Sqrt((x + 0) * (x + 0) + (y - 6) * (y - 6)) - v * t);
                    z3 = w * (Math.Sqrt((x - ((Math.Sqrt(3) * 8) / 2)) * (x - ((Math.Sqrt(3) * 8) / 2)) + (y - 2) * (y - 2)) - v * t);
                    //z3 = w * (Math.Sqrt((x +1) * (x +1) + (y + 3) * (y + 3)) - v * t);
                    //z1 = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3)) - v * t);
                    //z2 = w * (Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3)) - v * t);
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z1 + z2 +z3 ;
                    colorO = (int)(z * 2.5);//2.5 // 3.6 para dos 
                    c = paleta1[colorO];
                    lienzo.SetPixel(i, j, c);
                }
            }
        }
        public void Interferencia3D(Bitmap lienzo)
        {

            int i, j, colorO;
            double x, y, z, z1, z2, z3, w, v, m;
            w = 1.5;
            v = 9.3;
            m = 0.5;

            Vector3D v3d = new Vector3D();
            x = -8;
            do
            {
                y = -5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;

                    z1 = w * (Math.Sqrt((x - 5) * (x - 5) + (y - 0) * (y - 0)) - v * t);
                    z2 = w * (Math.Sqrt((x + 5) * (x + 5) + (y + 0) * (y + 0)) - v * t);
                    //z3 = w * (Math.Sqrt((x + 5) * (x + 5) + (y + 2) * (y + 2)) - v * t);
                    z1 = m * Math.Sin(z1);
                    z2 = m * Math.Sin(z2);
                    // z3 = Math.Sin(z3) + 1;
                    z = z1 + z2;
                    v3d.z0 = z;
                    v3d.color0 = Color.Green;
                    v3d.Encender(lienzo);
                    y = y + 0.1;
                } while (y < 5);
                x = x + 0.1;
            } while (x < 8);

        }

        public void Huyguens(Bitmap lienzo)
        {
            w = 2.5;
            v = 9.3;
            
            int i, j, Color0, l;
            double x, y, z, z1, z2;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 420; j++)
                {
                    z = 0;
                    transforma(i, j, out x, out y);

                    for (l = 0; l < 13; l++)
                    {
                        z1 = w * (Math.Sqrt(Math.Pow((x - 6 + l), 2) + Math.Pow(y + 0, 2)) - v * t); ;
                        z1 = Math.Sin(z1) + 1;
                        z += z1;
                    }
                    Color0 = (int)((13 + z) % 15);
                    c = Paleta3[Color0];
                    lienzo.SetPixel(i, j, c);


                }
            }
        }
        public void principioHuygens(Bitmap pixel)
        {
            int color1;
            Double z, z1, z2, m, w,t;
            w = 2.5;
            v = 9.3;
            m = 1;
            t = 0;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    transforma(i, j, out Double x, out Double y);
                    z = 0;
                    for (int l = 0; l < 13; l++)
                    {
                        z1 = w * (Math.Sqrt(Math.Pow((x - 6 + l), 2) + Math.Pow((y + 0), 2)) - v * t);
                        z = m * Math.Sin(z1) + z;
                    }
                    color1 = (int)((13 + z) * 0.58);
                    c = Paleta3[color1];

                    pixel.SetPixel(i, j, c);
                }
            }
        }
        public void procesoTercerPunto(double x1, double y1, double x2, double y2, out double x3, out double y3)
        {
            double ry;
            double altura;
            ry = (y1 + y2) / 2;
            altura = Math.Sqrt(3) * (y1 + (-1 * y2)) / 2;
            x3 = altura;
            y3 = ry;
        }

    }
}
