using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Меню
{
    public partial class frmTS : Form
    {
        private int n;
        private int w;
        private int h;
        private Bitmap serp;
        private Graphics g;
        public frmTS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain thirt_form = new frmMain();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

       private void button3_Click(object sender, EventArgs e)
       {
           double kolvo_ost, kolvo_vil;
           w = pictureBox1.Width;
           h = pictureBox1.Height;
           n = (int)dmn_updown.Value;
           kolvo_vil = 1 * (Math.Pow(3, n) - 1) / 2;
           label5.Text = Convert.ToString("Кількість вилучених трикутників - " + kolvo_vil);
           kolvo_ost = Math.Pow(3, n);
           label6.Text = Convert.ToString("Кількість залишившихся трикутників - " + kolvo_ost);
           serp = new Bitmap(w, h);
           //cоздаем новый объект из Bitmap
           g = Graphics.FromImage(serp);
           //вершины треугольника
           PointF topPoint = new PointF(w / 2f, 0);
           PointF leftPoint = new PointF(0, h);
           PointF rightPoint = new PointF(w, h);
           //отрисовка
           DrawTriangle(n, topPoint, leftPoint, rightPoint);
           pictureBox1.BackgroundImage = serp;
       }
       private void DrawTriangle(int n, PointF top, PointF left, PointF right)
       {
           //проверка конца построения
           if (n == 0)
           {
               PointF[] points = new PointF[3]
                {
                    top, right, left
                };
               g.FillPolygon(Brushes.BlueViolet, points);
           }
           else
           {
               var leftMid = MidPoint(top, left); //левая сторона
               var rightMid = MidPoint(top, right); //правая сторона
               var topMid = MidPoint(left, right); // основание
               DrawTriangle(n - 1, top, leftMid, rightMid);
               DrawTriangle(n - 1, leftMid, left, topMid);
               DrawTriangle(n - 1, rightMid, topMid, right);
           }
       }
       private PointF MidPoint(PointF p1, PointF p2)
       {
           //Среднняя точка
           return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
       }

        private void button8_Click(object sender, EventArgs e)
        {
            frmPract thirt_form = new frmPract();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTS2 thirt_form = new frmTS2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmTS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
 }

