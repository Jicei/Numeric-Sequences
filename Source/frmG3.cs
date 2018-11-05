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
    public partial class frmG3 : Form
    {
        static Graphics g;
        //static Pen pen1;
        public frmG3()
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a,S,P;
            g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            Pen pen1 = new Pen(Color.Black, 1);
            int xa, ya, xb, yb, xc, yc, n, i, xa1, ya1;
            xa = 250;
            ya = 100;
            xb = 410;
            yb = 380;
            xc = 90;
            yc = 380;
            a = (int)numericUpDown1.Value;
            n = (int)dmn_updown.Value;
            //S = (((a * a) * Math.Sqrt(3) / 4) * (Math.Pow(1 / 4, n) - 1)) / (1 / 4 - 1);
            S = ((Math.Pow((double)1 / 4, n) - 1)*(Math.Pow(a, 2) * Math.Sqrt(3) / 4)) / ((double)1 / 4 - 1);
            P = (3 * a * (Math.Pow((double)1 / 2, n) - 1)) / ((double)1 / 2 - 1);
            label5.Text = Convert.ToString("Сума площ трикутників - " + Math.Round(S, 2));
            label6.Text = Convert.ToString("Сума периметрів трикутників - " + Math.Round(P, 2));
            for (i = 0; i < n; i++)
            {
            g.DrawLine(pen1, xa, ya, xb, yb);
            g.DrawLine(pen1, xb, yb, xc, yc);
            g.DrawLine(pen1, xc, yc, xa, ya);
            Thread.Sleep(100);
                xa1 = xa;
                ya1 = ya;
                xa = (xa + xb) / 2;
                ya = (ya + yb) / 2;
                yb = (yb + yc) / 2;
                yc = (yc + ya1) / 2;
                xb = (xb + xc) / 2;
                xc = (xc + xa1) / 2;
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
            frmG3_2 thirt_form = new frmG3_2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmG3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
