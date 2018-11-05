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
    public partial class frmG4 : Form
    {
        public frmG4()
        {
            InitializeComponent();
        }
        static Graphics g;
        //static Pen pen1 pen2;
        private void button2_Click(object sender, EventArgs e)
        {
            frmMain thirt_form = new frmMain();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            Pen pen1 = new Pen(Color.Black, 1);
            Pen pen2 = new Pen(Color.White, 1);
            int xa, ya, xb, yb, yc, xc, yd, xd, n, r, i, xa1, ya1, r0, x0, y0;
            double l,a,P,L,S;
            a = (int)numericUpDown1.Value;
            n = (int)dmn_updown.Value;
            P = ((4 * a * Math.Sqrt(2)) / (Math.Sqrt(2) - 1))*(Math.Pow((double)1 / 2, n) - 1) / ((double)1 / 2 - 1);
            L = (2 * Math.PI * a / 2) / (1 - (1 / Math.Sqrt(2)));
            S = (Math.PI * a * a / 2)*((Math.Pow((double)1 / 4, n) - 1) / (double)1 / 4 - 1);
            label10.Text = Convert.ToString("Площа усіх квадратів -  " + Math.Abs(Math.Round(S, 2)));
            label9.Text = Convert.ToString("Периметр усіх квадратів - " + Math.Round(P, 2));
            label8.Text = Convert.ToString("Довжина кіл - " + Math.Round(L, 2));
            xa = 70;
            ya = 50;
            xb = 470;
            yb = 50;
            xc = 470;
            yc = 450;
            xd = 70;
            yd = 450;

            g.DrawLine(pen2, xa, ya, xb, yb);
            g.DrawLine(pen2, xb, yb, xc, yc);
            g.DrawLine(pen2, xc, yc, xd, yd);
            g.DrawLine(pen2, xd, yd, xa, ya);

            l = Math.Sqrt(((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya)));
            r = Convert.ToInt32(l);
            g.DrawEllipse(Pens.Green, xa, ya, r, r);
            Thread.Sleep(100);
            xa1 = xa;
            ya1 = ya;
            xa = (xa + xb) / 2;
            ya = (ya + yb) / 2;
            xb = (xb + xc) / 2;
            yb = (yb + yc) / 2;
            xc = (xc + xd) / 2;
            yc = (yc + yd) / 2;
            xd = (xa1 + xd) / 2;
            yd = (ya1 + yd) / 2;
            g.DrawLine(pen1, xa, ya, xb, yb);
            g.DrawLine(pen1, xb, yb, xc, yc);
            g.DrawLine(pen1, xc, yc, xd, yd);
            g.DrawLine(pen1, xd, yd, xa, ya);
            Thread.Sleep(100);
            l = Math.Sqrt(((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya)));
            r = Convert.ToInt32(l);
            r0 = r / 2;
            x0 = (xa + xc) / 2;
            y0 = (ya + yc) / 2;
            g.DrawEllipse(Pens.Green, x0 - r0, y0 - r0, r, r);
            Thread.Sleep(100);
            for (i = 1; i < n; i++)
            {
                xa1 = xa;
                ya1 = ya;
                xa = (xa + xb) / 2;
                ya = (ya + yb) / 2;
                xb = (xb + xc) / 2;
                yb = (yb + yc) / 2;
                xc = (xc + xd) / 2;
                yc = (yc + yd) / 2;
                xd = (xa1 + xd) / 2;
                yd = (ya1 + yd) / 2;
                l = Math.Sqrt(((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya)));
                r = Convert.ToInt32(l);
                r0 = r / 2;
                x0 = (xa + xc) / 2;
                y0 = (ya + yc) / 2;
                g.DrawEllipse(Pens.Green, x0 - r0, y0 - r0, r, r);
                Thread.Sleep(100);
                g.DrawLine(pen1, xa, ya, xb, yb);
                g.DrawLine(pen1, xb, yb, xc, yc);
                g.DrawLine(pen1, xc, yc, xd, yd);
                g.DrawLine(pen1, xd, yd, xa, ya);
                Thread.Sleep(100);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGeom thirt_form = new frmGeom();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmG4_2 thirt_form = new frmG4_2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmG4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
