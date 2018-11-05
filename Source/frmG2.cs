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
    public partial class frmG2 : Form
    {
        public frmG2()
        {
            InitializeComponent();
        }
        static Graphics g;
        //static Pen pen1;
        private void button2_Click(object sender, EventArgs e)
        {
            frmMain thirt_form = new frmMain();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, S, P;
            g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            Pen pen1 = new Pen(Color.Black, 1);
            int xa, ya, xb, yb, yc, xc, yd, xd, n, i, xa1, ya1;
            a = (int)numericUpDown1.Value;
            n = (int)dmn_updown.Value;
            S = 2 * a * a*(Math.Pow((double)1 / 4, n) - 1) / ((double)1 / 4 - 1);
            P = ((4 * a * Math.Sqrt(2)) / (Math.Sqrt(2) - 1))*(Math.Pow((double)1 / 2, n) - 1) / ((double)1 / 2 - 1);;
            label5.Text = Convert.ToString("Площа усіх квадратів - " + Math.Round(S, 2));
            label6.Text = Convert.ToString("Периметр усіх квадратів - " + Math.Round(P, 2));
            xa = 70;
            ya = 50;
            xb = 470;
            yb = 50;
            xc = 470;
            yc = 450;
            xd = 70;
            yd = 450;
            for (i = 0; i < n; i++)
            {
            g.DrawLine(pen1, xa, ya, xb, yb);
            g.DrawLine(pen1, xb, yb, xc, yc);
            g.DrawLine(pen1, xc, yc, xd, yd);
            g.DrawLine(pen1, xd, yd, xa, ya);
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
            frmG6_2 thirt_form = new frmG6_2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmG2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
