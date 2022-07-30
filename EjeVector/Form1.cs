using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjeVector
{
    public partial class Form1 : Form
    {
       Color[] paleta1 = new Color[16];

        public Form1()
        {
            InitializeComponent();
            

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

        }

        Bitmap pixel = new Bitmap(700, 420);

        private void vector_Click(object sender, EventArgs e)
        {
            Vector V = new Vector();
            V.x0 = 0;
            V.y0 = 1;
            V.color0 = Color.Red;
            V.Encender(pixel);
            V.x0 = -1;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(pixel);
            V.x0 = 1;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(pixel);
            V.x0 = 0;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(pixel);
            V.y0 = 3;
            V.color0 = Color.Red;
            V.Encender(pixel);
            V.x0 = 5;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(pixel);
            pictureBox1.Image = pixel;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Segmento_Click(object sender, EventArgs e)
        {
            
            Segmento S = new Segmento();


            S.x0 = -10;
            S.y0 = 0;

            S.xf = 10;
            S.yf = 0;

            S.color0 = Color.Red;
            S.Encender(pixel);
           

            S.x0 = 0;
            S.y0 = -5.98;

            S.xf = 0;
            S.yf = 5.98;

            S.color0 = Color.Red;
            S.Encender(pixel);
            pictureBox1.Image = pixel;

        }

        private void Circunferencia_Click(object sender, EventArgs e)
        {
            Circunferencia C = new Circunferencia();
            C.x0 = 0;
            C.y0 = 0;
            C.Rd = 3;
            C.color0 = Color.Red;
            C.Encender(pixel);
            pictureBox1.Image= pixel;

        }

        private void Lazo_Click(object sender, EventArgs e)
        {
            Lazo L = new Lazo();    
            L.x0 = 0;
            L.y0 = 0;
            L.Rd = 2;
            L.color0 = Color.Red;
            L.Encender(pixel);
            pictureBox1.Image = pixel;

        }

        private void ejes_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -10;
            S.y0 = 0;

            S.xf = 10;
            S.yf = 0;

            S.color0 = Color.Black;
            S.Encender(pixel);


            S.x0 = 0;
            S.y0 = -5.98;

            S.xf = 0;
            S.yf = 5.98;

            S.color0 = Color.Red;
            S.Encender(pixel);
            pictureBox1.Image = pixel;

        }

        private void Segmento2_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -7;
            S.y0 = -2;

            S.xf = 3;
            S.yf = 4;

            S.color0 = Color.Black;
            S.Encender(pixel);
            pictureBox1.Image = pixel;

            Circunferencia C = new Circunferencia();
            C.x0 = 6;
            C.y0 = 1;
            C.Rd = 3;
            C.color0 = Color.Black;
            C.Encender(pixel);
            pictureBox1.Image = pixel;

            Lazo L = new Lazo();
            L.x0 = -5;
            L.y0 = 3;
            L.Rd = 2;
            L.color0 = Color.Green;
            L.Encender(pixel);
            pictureBox1.Image = pixel;


        }

        private void Graficar2_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -8;
            S.y0 = 4;

            S.xf = 5;
            S.yf = 2;

            S.color0 = Color.Black;
            S.Encender(pixel);


            S.x0 = -6;
            S.y0 = -4;

            S.xf = 5;
            S.yf = 2;

            S.color0 = Color.Black;
            S.Encender(pixel);
            pictureBox1.Image = pixel;

            Circunferencia C = new Circunferencia();
            C.x0 = 5;
            C.y0 = 2;
            C.Rd = 1;
            C.color0 = Color.Black;
            C.Encender(pixel);
            pictureBox1.Image = pixel;

            
            C.x0 = -6;
            C.y0 = 0;
            C.Rd = 3;
            C.color0 = Color.Black;
            C.Encender(pixel);
            pictureBox1.Image = pixel;

            Lazo L = new Lazo();
            L.x0 = -6;
            L.y0 = 1.5;
            L.Rd = 1;
            L.color0 = Color.Green;
            L.Encender(pixel);
            pictureBox1.Image = pixel;

            L.x0 = 4;
            L.y0 = -3;
            L.Rd = 2;
            L.color0 = Color.Green;
            L.Encender(pixel);
            pictureBox1.Image = pixel;

            Raiz R = new Raiz();
            R.x0 = 2;
            R.y0 = 4;
            R.Rd = 1;
            R.color0 = Color.Green;
            R.Encender(pixel);
            pictureBox1.Image = pixel;

        }

        private void vector3D_Click(object sender, EventArgs e)
        {
            double h = 0;
            do
            {
                Vector3D v3D = new Vector3D();
                v3D.x0 = 2 + 3 * (Math.Cos(h));
                v3D.y0 = 1 + 2 * (Math.Sin(h));
                v3D.z0 = -2 + (h/5);
                v3D.color0 = Color.Green;
                v3D.Encender(pixel);

                h = h + 0.002;

            } while (h <= 15);
            pictureBox1.Image = pixel;
        }

        private void Segmento3D_Click(object sender, EventArgs e)
        {
            Segmento3D Sv3D = new Segmento3D();

            Sv3D.x0 = 0;
            Sv3D.y0 = 0;
            Sv3D.z0 = 0;
            Sv3D.xf = 8;
            Sv3D.yf = 0;
            Sv3D.zf = 0;
            Sv3D.color0 = Color.Black;
            Sv3D.Encender(pixel);
            pictureBox1.Image = pixel;


            Sv3D.x0 = 0;
            Sv3D.y0 = 0;
            Sv3D.z0 = 0;
            Sv3D.xf = 0;
            Sv3D.yf = 0;
            Sv3D.zf = 5;
            Sv3D.color0 = Color.Coral;
            Sv3D.Encender(pixel);
            pictureBox1.Image = pixel;



            Sv3D.x0 = 0;
            Sv3D.y0 = 0;
            Sv3D.z0 = 0;
            Sv3D.xf = 0;
            Sv3D.yf = 5;
            Sv3D.zf = 0;
            Sv3D.color0 = Color.Yellow;
            Sv3D.Encender(pixel);
            pictureBox1.Image = pixel;

             
             Sv3D.x0 = 0;
             Sv3D.y0 = 0;
             Sv3D.z0 = 5;

             Sv3D.xf = 8;
             Sv3D.yf = 0;
             Sv3D.zf = 5;
             Sv3D.color0 = Color.Red;
             Sv3D.Encender(pixel);
             pictureBox1.Image = pixel;


             Sv3D.x0 = 8;
             Sv3D.y0 = 0;
             Sv3D.z0 = 5;

             Sv3D.xf = 8;
             Sv3D.yf = 0;
             Sv3D.zf = 0;
             Sv3D.color0 = Color.Red;
             Sv3D.Encender(pixel);
             pictureBox1.Image = pixel;


             Sv3D.x0 = 0;
             Sv3D.y0 = 0;
             Sv3D.z0 = 5;

             Sv3D.xf = 0;
             Sv3D.yf = 5;
             Sv3D.zf = 5;
             Sv3D.color0 = Color.Red;
             Sv3D.Encender(pixel);
             pictureBox1.Image = pixel;


             Sv3D.x0 = 0;
             Sv3D.y0 = 5;
             Sv3D.z0 = 5;

             Sv3D.xf = 0;
             Sv3D.yf = 5;
             Sv3D.zf = 0;
             Sv3D.color0 = Color.Red;
             Sv3D.Encender(pixel);
             pictureBox1.Image = pixel;

             Sv3D.x0 = 0;
             Sv3D.y0 = 5;
             Sv3D.z0 = 0;

             Sv3D.xf = 8;
             Sv3D.yf = 5;
             Sv3D.zf = 0;
             Sv3D.color0 = Color.Red;
             Sv3D.Encender(pixel);
             pictureBox1.Image = pixel;


             Sv3D.x0 = 8;
             Sv3D.y0 = 5;
             Sv3D.z0 = 0;

             Sv3D.xf = 8;
             Sv3D.yf = 0;
             Sv3D.zf = 0;
             Sv3D.color0 = Color.Red;
             Sv3D.Encender(pixel);
             pictureBox1.Image = pixel;

            double h = 0;
            do
            {
                Vector3D v3D = new Vector3D();
                v3D.x0 = -4 + 1 * (Math.Cos(h));
                v3D.y0 = 2 + 1 * (Math.Sin(h));
                v3D.z0 = -1 + (h / 5);
                v3D.color0 = Color.Green;
                v3D.Encender(pixel);

                h = h + 0.002;

            } while (h <= 15);
            pictureBox1.Image = pixel;

            h = 0; 
            do
            {
                Vector3D v3D = new Vector3D();
                v3D.x0 = 2 + 0.5 * (Math.Cos(h));
                v3D.y0 = 1 + 0.7 * (Math.Sin(h));
                v3D.z0 = -2 + (h / 2);
                v3D.color0 = Color.Blue;
                v3D.Encender(pixel);

                h = h + 0.002;

            } while (h <= 15);
            pictureBox1.Image = pixel;

            h = 0;
            do
            {
                Vector3D v3D = new Vector3D();
                v3D.x0 = 1 + 1 * (Math.Cos(h));
                v3D.y0 = 1 + 2 * (Math.Sin(h));
                v3D.z0 = -2 + (h / 10);
                v3D.color0 = Color.Black;
                v3D.Encender(pixel);

                h = h + 0.002;

            } while (h <= 15);
            pictureBox1.Image = pixel;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i<700; i++ ) 
            {
                for (int j=0; j<420;j++) 
                {
                    pixel.SetPixel(i, j, Color.FromArgb(255, 0, (int)((255*i)/700), (-255*(i-700))/700));
                    pictureBox1.Image = pixel;
                }
            }



        }

        private void apagarpixel_Click(object sender, EventArgs e)
        {
            for (int Xcount = 0; Xcount < pixel.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < pixel.Height; Ycount++)
                {
                    pixel.SetPixel(Xcount, Ycount, Color.White);
                }
            }
            pictureBox1.Image = pixel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    //pixel.SetPixel(i, j, Color.FromArgb(255, (255 * (i - 700) / -700), ((255 * (i - 700)) / -700), 255 * i / 700));
                    pixel.SetPixel(i, j, Color.FromArgb(255, 255 * i / 700, 255 * i / 700, ((255 * (i - 700)) / -700)));

                    pictureBox1.Image = pixel;

                }
            }
        }

        private void paraboloide_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D();
            v.color0 = Color.Red;
            double t = -5;
            do
            {
                double h = -4;
                do
                {
                    v.x0 = t;
                    v.y0 = h;
                    v.z0 = 0.25 * ((t * t) + (h * h)) - 5;
                    
                    v.Encender(pixel);
                    h = h + 0.1;


                } while (h <= 4);
                t = t + 0.1;
            
            } while (t<=5);
            pictureBox1.Image = pixel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D();
            v.color0 = Color.Red;
            double t = -5;
            do
            {
                double h = -4;
                do
                {
                    v.x0 = t;
                    v.y0 = h;
                    v.z0 = 0.15 * ((t * t) - (h * h)) - 3;

                    v.Encender(pixel);
                    h = h + 0.1;


                } while (h <= 4);
                t = t + 0.1;

            } while (t <= 5);
            pictureBox1.Image = pixel;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 350; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    pixel.SetPixel(i, j, Color.FromArgb(((255 * (i - 350)) / -350) + ((255 * i) / 350), ((255 * (i - 350)) / -350) + ((255 * i) / 350), (255 * i) / 350));
                    pictureBox1.Image = pixel;
                }
            }

            for (int i = 350; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    pixel.SetPixel(i, j, Color.FromArgb((255 * (i - 700)) / -350, (255 * (i - 700)) / -350, ((255 * (i - 700)) / -350) + ((255 * (i - 350)) / 350)));
                    pictureBox1.Image = pixel;
                }
            }
        }

        private void tiroPrabolico_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            double p = -3;
           
            do {
                v.x0 = p;
                v.y0 = (-(p*p) +(5*p) +24) / 6.2;
                v.color0 = Color.Black;
                v.Encender(pixel);

                p = p + 0.001;

            } while (p<=8);
            pictureBox1.Image = pixel;

            
            Circunferencia c = new Circunferencia();
            double t = -3;
            c.Rd = 0.2;
            do {
                c.x0 = t;
                c.y0 = (-(t * t) + (5 * t) + 24) / 6.2;
                
                c.color0 = Color.Green;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(25);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                t = t + 0.1;
               
            } while (t <= 8);
           







        }

        private void button5_Click(object sender, EventArgs e)
        {
            double t = 4;
            Circunferencia c = new Circunferencia();
            Vector v = new Vector();

            double w = 1;
            double p = -4;
            double q = -10;

            do
            {
                v.x0 = q;
                //v.y0 = (-(p * p) - (3 * p)+4)/2;
                v.y0 = (-(q * q) - (14 * q) - 40) / 3.5;
                v.color0 = Color.Black;
                v.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                q = q + 0.01;

            } while (q <= -4);
            pictureBox1.Image = pixel;
            do
            {
                v.x0 = p;
                v.y0 = (-(p * p) - (3 * p) + 4) / 4;
                v.color0 = Color.Black;
                v.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                p = p + 0.01;

            } while (p <= 1);
            pictureBox1.Image = pixel;
            do
            {
                v.x0 = w;
                v.y0 = ((-Math.Pow(w, 2)) + (5 * w) - 4) / (4);
                v.color0 = Color.Black;
                v.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                w = w + 0.01;
            } while (w <= 4);
            pictureBox1.Image = pixel;


            do
            {
                v.x0 = t;
                v.y0 = (-(t * t) + (10 * t) - 24) / 5;
                v.color0 = Color.Black;
                v.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                //Thread.Sleep(1);
                t = t + 0.01;

            } while (t <= 6);
            pictureBox1.Image = pixel;

           
            //circulo

            
            double q1 = -10;
            c.Rd = 0.2;
            do
            {
                c.x0 = q1;
                c.y0 = (-(q1 * q1) - (14 * q1) - 40) / 3.5;

                c.color0 = Color.Green;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(25);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                q1 = q1 + 0.1;

            } while (q1 <= -4);

            double q2 = -4;
           
            do
            {
                c.x0 = q2;
                c.y0 = (-(q2 * q2) - (3 * q2) + 4) / 4;

                c.color0 = Color.Green;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(25);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                q2 = q2 + 0.1;

            } while (q2 <= 1);

            double q3 = 1;

            do
            {
                c.x0 = q3;
                c.y0 = ((-Math.Pow(q3, 2)) + (5 * q3) - 4) / (4);

                c.color0 = Color.Green;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(25);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                q3 = q3 + 0.1;

            } while (q3 <= 4);

            double q4 = 4;

            do
            {
                c.x0 = q4;
                c.y0 = (-(q4 * q4) + (10 * q4) - 24) / 5;

                c.color0 = Color.Green;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(25);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                q4 = q4 + 0.1;

            } while (q4 <= 6);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            circunferencia_color C = new circunferencia_color();
            C.x0 = 0;
            C.y0 = 0;
            C.Radio = 3;
            //C.color0 = Color.Red;

            C.Encender(pixel);
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = pixel;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 350; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    pixel.SetPixel(i, j, Color.FromArgb(255, 255, 255, (int)(255*i)/350));
                    pictureBox1.Image = pixel;
                }
            }

            for (int i = 350; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    pixel.SetPixel(i, j, Color.FromArgb(255, (int)(255*(i-700)/-350), (255 * (i - 700) / -350), 255));
                    pictureBox1.Image = pixel;
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Segmento_P S = new Segmento_P();
            S.x0 = -7;
            S.y0 = -2;

            S.xf = 3;
            S.yf = 4;
            S.Encender(pixel);
            //pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = pixel;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lazo_P L = new Lazo_P();
            L.x0 = 0;
            L.y0 = 0;
            L.Rd = 2;
            
            L.Encender(pixel);
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = pixel;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = 1;
            S.y0 = -1;

            S.xf = 9.30;
            S.yf = 5.98;

            S.color0 = Color.Black;
            S.Encender(pixel);
            pictureBox1.Image = pixel;


            S.x0 = 9.30;
            S.y0 = 5.98;

            S.xf = 10;
            S.yf = 5.39;

            S.color0 = Color.Blue;
            S.Encender(pixel);
            pictureBox1.Image = pixel;

            S.x0 = 10;
            S.y0 = 5.39;

            S.xf = -3.53;
            S.yf = -5.98;

            S.color0 = Color.Red;
            S.Encender(pixel);
            pictureBox1.Image = pixel;
            //pictureBox1.BackColor = Color.Black;

            ////////////////////////////////////////////////
            ///
            Circunferencia c = new Circunferencia();

            double t = 0;
            c.Rd = 0.2;
            do
            {
                c.x0 = (1 * (1 - t)) + (9.30 * t);
                c.y0 = (-1* (1 - t)) + (5.98 * t);
                c.color0 = Color.Black;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(200);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                t = t + 0.1;
            } while (t <= 1);

            double z = 0;
            c.Rd = 0.2;

            do
            {
                c.x0 = (9.30 * (1 - z)) + (10 * z);
                c.y0 = (5.98 * (1 - z)) + (5.39 * z);
                c.color0 = Color.Red;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(200);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                z = z + 0.1;
            } while (z <= 1);
            
            double y = 0;
            c.Rd = 0.2;
            do
            {
               
                c.x0 = (10 * (1 - y)) + (-3.53 * y);
                c.y0 = (5.39 * (1 - y)) + (-5.98 * y);
                c.color0 = Color.Black;
                c.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(200);
                c.Apagar(pixel);
                pictureBox1.Image = pixel;
                y = y + 0.1;
            } while (y <= 1);


        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = pixel;
            Circunferencia C = new Circunferencia();
            C.x0 = 0;
            C.y0 = 0;
            C.Rd = 3;
            C.color0 = Color.Green;
            C.Encender(pixel);
            pictureBox1.Image = pixel;

            C.x0 = 0;
            C.y0 = 0;
            C.Rd = 5;
            C.color0 = Color.Blue;
            C.Encender(pixel);
            pictureBox1.Image = pixel;

            double t = 2.5;
            C.Rd = 0.4;
            C.x0 = t;
            C.y0 = t;
            float r = 4;
            do
            {

                C.x0 = 0 + r * Math.Cos(t);
                C.y0 = 0 + r * Math.Sin(t);

                C.color0 = Color.Red;
                C.Encender(pixel);
                pictureBox1.Refresh();
                Thread.Sleep(50);
                C.color0 = Color.White;
                C.Encender(pixel);
                Thread.Sleep(50);
                //C.Apagar(lienzo3);

                t = t+ 0.1;
                if (t >= (2 * Math.PI))
                {
                    t = 0;
                }
            }while (t <= 2 * Math.PI);


        }

        private void button12_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            double t = -2.8;

            do
            {
                v.x0 = t;
                v.y0 = 1 / (t + 3);
                v.color0 = Color.Blue;
                v.Encender(pixel);
                v.color0 = Color.Red;
                v.y0 = (0.33) - (t / 9) + ((Math.Pow(t, 2) / 27));
                v.Encender(pixel);
                t = t + 0.001;

            } while (t <= 10);
            pictureBox1.Image = pixel;


           

        }
        private void button14_Click(object sender, EventArgs e)
        {
            Circunferencia circunferencia = new Circunferencia();
            circunferencia.x0 = 0;
            circunferencia.y0 = 0;
            circunferencia.Rd = 3;
            circunferencia.color0 = Color.Blue;
            circunferencia.Encender(pixel);
            pictureBox1.Image = pixel;
            double t = 0;
            double dt = 0.1;
            Segmento segmento = new Segmento();
            segmento.x0 = 0;
            segmento.y0 = 0;
            do
            {
                segmento.xf = segmento.x0 + (circunferencia.Rd * (Math.Cos(t))); ;
                segmento.yf = segmento.y0 + (circunferencia.Rd * (Math.Sin(t))); ;
                segmento.color0 = Color.Black;
                segmento.Encender(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                Thread.Sleep(40);
                segmento.Apagar(pixel);
                pictureBox1.Image = pixel;
                t = t + dt;
            } while (t <= 2 * Math.PI);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
            o.v = 9.3;
            o.w = 1.8;
            o.t = 0;
            o.m = 1;
            o.graf(pixel);
            pictureBox1.Image = pixel;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Onda O = new Onda();

            O.GrafOnda3D(pixel);
            pictureBox1.Image = pixel;
        }

        private void interferencia_Click(object sender, EventArgs e)
        {
            Onda O = new Onda();

            O.Interferencia(pixel);
            pictureBox1.Image = pixel;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Onda O = new Onda();

            O.Interferencia3D(pixel);
            pictureBox1.Image = pixel;

        }

        private void animacionOnda_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0.5;

            //Con animacion
            do
            {
                o.v = 9.3;
                o.w = 2;
                o.graf(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                t = t + 0.1;
                o.t = t;
            } while (t <= 4);

        }

        private void InterferenciaAnimada_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;

            //Con animacion
            do
            {
                o.v = 9.3;
                o.w = 2;
                o.Interferencia(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.Refresh();
                t = t + 0.1;
                o.t = t;
            } while (t <= 10);
        }

        private void AnimacionOnda3D_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
         
            do
            {
                o.v = 9.3;
                o.w = 1.5;
                o.t = t;
                o.GrafOnda3D(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.BackColor = Color.Black;
                Refresh();
                pixel = null;
                pixel = new Bitmap(700, 420);
                Thread.Sleep(5);
                t = t + 0.04;
            } while (t <= 10);
        }

        private void InterferenciaAnimad3D_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(700, 420);
            pictureBox1.BackColor = Color.Black;
            double t = 0, h = 0;
            double dh = 0.05;
            Onda o = new Onda();



            do
            {
                o.v = 9.3;
                o.w = 1.5;
                o.t = t;
                o.Interferencia3D(bitmap);
                o.Encender(bitmap);
                pictureBox1.Image = bitmap;
                pictureBox1.Refresh();
                bitmap = null;
                bitmap = new Bitmap(650, 500);
                Thread.Sleep(50);
                t += 0.015;
            } while (t <= 6.28);
        }

        private void Huyguens_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
           
            o.principioHuygens(pixel);
            pictureBox1.Image = pixel;
        }

        private void animacionSegmentoParaboloide_Click(object sender, EventArgs e)
        {
            double p1 = -7;
            Vector v = new Vector();
            do
            {
                if (p1 <= -2)
                {
                    v.x0 = p1;
                    v.y0 = (((1.2) * p1) +5.4);
                    v.color0 = Color.Green;
                    v.Encender(pixel);
                }
                else
                {
                    v.x0 = p1;
                    v.y0 = ((((p1 - 1) * (p1 - 1)) / 3) - (5 * ((p1 + 2) * (p1 - 4)) / 9));
                    v.color0 = Color.Green;
                    v.Encender(pixel);

                }
                p1 = p1 + 0.001;

            } while (p1 <= 4);
            pictureBox1.Image = pixel;
            //pictureBox1.BackColor = Color.Black;

            double p; 
            Circunferencia c = new Circunferencia();
            p = -7;
            c.Rd = 0.4;
            do
            {
                if (p <= -2)
                {
                    c.x0 = p;
                    c.y0 = (((1.2) * p) + (5.4));
                    c.color0 = Color.Green;
                    c.Encender(pixel);
                    pictureBox1.Image = pixel;
                    pictureBox1.Refresh();
                    Thread.Sleep(20);
                    c.Apagar(pixel);
                    pictureBox1.Image = pixel;
                    //pictureBox1.BackColor = Color.Black;
                }
                else
                {
                    c.x0 = p;
                    c.y0 = ((((p - 1) * (p - 1)) / 3) - (5 * ((p + 2) * (p - 4)) / 9));
                    c.color0 = Color.Red;
                    c.Encender(pixel);
                    pictureBox1.Image = pixel;
                    pictureBox1.Refresh();
                    Thread.Sleep(20);
                    c.Apagar(pixel);
                    pictureBox1.Image = pixel;
                    //pictureBox1.BackColor = Color.Black;
                }
                p += 0.2;
            } while (p <= 4);
        }

        private void puntos_Click(object sender, EventArgs e)
        {
            Circunferencia C = new Circunferencia();
            C.x0 = -7;
            C.y0 = -3;
            C.Rd = 0.4;
            C.color0 = Color.Red;
            C.Encender(pixel);
            C.x0 = -2;
            C.y0 = 3;
            C.color0 = Color.Red;
            C.Encender(pixel);
            C.x0 = -2;
            C.y0 = 3;
            C.color0 = Color.Red;
            C.Encender(pixel);
            C.x0 = 1;
            C.y0 = 5;
            C.color0 = Color.Red;
            C.Encender(pixel);
            C.x0 = 4;
            C.y0 = 3;
            C.color0 = Color.Red;
            C.Encender(pixel);
            pictureBox1.Image = pixel;

        }

        private void CuerdaVibrante_Click(object sender, EventArgs e)
        {
            CuerdaV cv = new CuerdaV();
            double t = 0;
            do
            {
                cv.Grafico(pixel);
                pictureBox1.Image = pixel;
                pictureBox1.BackColor = Color.Black;
                Refresh();
                pixel = null;
                pixel = new Bitmap(700, 420);
                Plano();
                Thread.Sleep(50);
                
                cv.t = t;
                t = t + 0.05;
            } while (t <= 2 * Math.PI);
        }
        private void Plano()
        {
            Segmento s = new Segmento();
            s.x0 = 0;
            s.y0 = 10.77;
            s.xf = 0;
            s.yf = -10.77;
            s.color0 = Color.Green;

            s.Encender(pixel);

            s.x0 = 14;
            s.y0 = 0;
            s.xf = -14;
            s.yf = 0;

            s.Encender(pixel);
            pictureBox1.Image = pixel;
        }

        private void CuerdaVibrante2_Click(object sender, EventArgs e)
        {
            double t = 0;
            Cuerda cv = new Cuerda();
            do
            {
                cv.GraficoC(pixel);
                pictureBox1.Image = pixel;
                Refresh();
                pixel = null;
                pixel = new Bitmap(700, 420);
                //Plano();
                Thread.Sleep(60);
                cv.t = t;
                t = t + 0.04;

                //Ejes
                Segmento S = new Segmento();
                S.x0 = -10;
                S.xf = 10;
                S.y0 = 0;
                S.yf = 0;
                S.color0 = Color.Red;
                S.Encender(pixel);
                S.x0 = 0;
                S.y0 = -5.98;
                S.xf = 0;
                S.yf = 5.98;
                S.color0 = Color.Red;
                S.Encender(pixel);
            } while (t <= 2 * Math.PI);
        }

        private void correccionPrueba3_Click(object sender, EventArgs e)
        {
            double p1 = 0;
            Vector v = new Vector();
            do
            {
                    v.x0 = p1;
                    v.y0 = ((-0.67*((p1*p1)-6*p1))+(0.22 * ((p1 * p1) - 3 * p1)));
                    v.color0 = Color.Green;
                    v.Encender(pixel);
                
                p1 = p1 + 0.001;

            } while (p1 <= 6);
            pictureBox1.Image = pixel;

            Circunferencia c = new Circunferencia();
           double p = 0;
            c.Rd = 0.5;
            do
            {
                
                    c.x0 = p;
                    c.y0 = ((-0.67 * ((p * p) - 6 * p)) + (0.22 * ((p * p) - 3 * p)));
                    c.color0 = Color.Green;
                    c.Encender(pixel);
                    pictureBox1.Image = pixel;
                    pictureBox1.Refresh();
                    Thread.Sleep(20);
                    c.Apagar(pixel);
                    pictureBox1.Image = pixel;
                    //pictureBox1.BackColor = Color.Black;
                p += 0.2;
            } while (p <= 6);
        }
    
    }
}
    

