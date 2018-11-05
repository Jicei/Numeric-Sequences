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
    public partial class frmG6 : Form
    {
        static Graphics g;
        //static Pen pen1, pen2;
        public frmG6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            Pen pen1 = new Pen(Color.Black, 1);
            Pen pen2 = new Pen(Color.White, 1);
            int xa, ya, xb, yb, yc, xc, yd, xd, n, r, i, r0, x0, y0, xtrian1, ytrian1, xtrian2b, ytrian2b, xtrian3b, ytrian3b;
            double l, strian, xtrian2, ytrian2, xtrian3, ytrian3,a,S,P;
            a = (int)numericUpDown1.Value;
            n = (int)dmn_updown.Value;
            S = ((a * a) * Math.Sqrt(3) / 4) * (Math.Pow((double)1 / 4, n) - 1) / ((double)1 / 4 - 1);
            label7.Text = Convert.ToString("Сума площ трикутників - " + Math.Round(S, 2));
            P = 3 * a * (Math.Pow((double)1 / 2, n) - 1) / ((double)1 / 2 - 1);
            label6.Text = Convert.ToString("Сума периметрів трикутників - " + Math.Round(P, 2));
            xa = 70;
            ya = 50;
            xb = 470;
            yb = 50;
            xc = 470;
            yc = 450;
            xd = 70;
            yd = 450;
            //квадрат
            g.DrawLine(pen2, xa, ya, xb, yb);
            g.DrawLine(pen2, xb, yb, xc, yc);
            g.DrawLine(pen2, xc, yc, xd, yd);
            g.DrawLine(pen2, xd, yd, xa, ya);
            x0 = (xa + xc) / 2;
            y0 = (ya + yc) / 2;
            l = Math.Sqrt(((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya)));
            r = Convert.ToInt32(l);
            r0 = r / 3;
            strian = 3 * Math.Sqrt(3) * r * 2 / 4;
            //круг
            g.DrawEllipse(Pens.Green, xa, ya, r, r);
            Thread.Sleep(100);
            xtrian1 = (xa + xb) / 2;
            ytrian1 = (ya + yb) / 2;
            xtrian2 = x0 - (xtrian1 - x0) / 2 + (ytrian1 - y0) * Math.Sqrt(3) / 2;
            ytrian2 = y0 - (xtrian1 - x0) * Math.Sqrt(3) / 2 - (ytrian1 - y0) / 2;
            xtrian2b = Convert.ToInt32(xtrian2);
            ytrian2b = Convert.ToInt32(ytrian2);
            xtrian3 = x0 - (xtrian1 - x0) / 2 - (ytrian1 - y0) * Math.Sqrt(3) / 2;
            ytrian3 = y0 + (xtrian1 - x0) * Math.Sqrt(3) / 2 - (ytrian1 - y0) / 2;
            xtrian3b = Convert.ToInt32(xtrian3);
            ytrian3b = Convert.ToInt32(ytrian3);
            //треугольник
            g.DrawLine(pen1, xtrian1, ytrian1, xtrian2b, ytrian2b);
            g.DrawLine(pen1, xtrian2b, ytrian2b, xtrian3b, ytrian3b);
            g.DrawLine(pen1, xtrian1, ytrian1, xtrian3b, ytrian3b);
            Thread.Sleep(100);
            //круг переменные
            double x0trian, y0trian, xm, ym, BM, xo, yo;
            int BMi, rtrian, xoi, yoi;
            for (i = 1; i < n; i++)
            {
                //круг
                x0trian = (xtrian1 + xtrian2b + xtrian3b) / 3;
                y0trian = (ytrian1 + ytrian2b + ytrian3b) / 3;
                xm = (xtrian2b + xtrian3b) / 2;
                ym = (ytrian2b + ytrian3b) / 2;
                BM = Math.Sqrt(((xtrian1 - xm) * (xtrian1 - xm)) + ((ytrian1 - ym) * (ytrian1 - ym)));
                BMi = Convert.ToInt32(BM);
                rtrian = BMi / 3;
                xo = x0trian - rtrian;
                yo = y0trian - rtrian;
                xoi = Convert.ToInt32(xo);
                yoi = Convert.ToInt32(yo);
                g.DrawEllipse(Pens.Green, xoi, yoi, 2 * rtrian, 2 * rtrian);
                Thread.Sleep(100);
                //треугольник
                xtrian1 = (xoi + xoi + 2 * rtrian) / 2;
                ytrian1 = yoi;
                xtrian2 = x0 - (xtrian1 - x0) / 2 + (ytrian1 - y0) * Math.Sqrt(3) / 2;
                ytrian2 = y0 - (xtrian1 - x0) * Math.Sqrt(3) / 2 - (ytrian1 - y0) / 2;
                xtrian2b = Convert.ToInt32(xtrian2);
                ytrian2b = Convert.ToInt32(ytrian2);
                xtrian3 = x0 - (xtrian1 - x0) / 2 - (ytrian1 - y0) * Math.Sqrt(3) / 2;
                ytrian3 = y0 + (xtrian1 - x0) * Math.Sqrt(3) / 2 - (ytrian1 - y0) / 2;
                xtrian3b = Convert.ToInt32(xtrian3);
                ytrian3b = Convert.ToInt32(ytrian3);
                g.DrawLine(pen1, xtrian1, ytrian1, xtrian2b, ytrian2b);
                g.DrawLine(pen1, xtrian2b, ytrian2b, xtrian3b, ytrian3b);
                g.DrawLine(pen1, xtrian1, ytrian1, xtrian3b, ytrian3b);
                Thread.Sleep(100);
            }
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
            frmGeom thirt_form = new frmGeom();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmG6_2 thirt_form = new frmG6_2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmG6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
