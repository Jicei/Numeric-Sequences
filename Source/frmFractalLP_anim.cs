using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Меню
{
    public partial class frmFractalLP_anim : Form
    {
        public frmFractalLP_anim()
        {
            InitializeComponent();
        }
        Point start = new Point(0, 0);
        int w;
        int h;
        int dx, dy, xa, xb, ya, yb;
        Graphics g;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            dx = (int)xStepNumericUpDown.Value;
            dy = (int)yStepNumericUpDown.Value;
            xa = -dx; ya = -dy; xb = 0; yb = 0;
            g = pictureBox1.CreateGraphics();
            w = (int)numericUpDown2.Value;
            h = (int)numericUpDown1.Value;
            Pen pen3 = new Pen(Color.Red, 2);
            SolidBrush b = new SolidBrush(Color.PaleVioletRed);
            g.DrawRectangle(pen3, 0, 0, w, h);
            g.FillRectangle(b, 0, 0, w, h);
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.White, 2);
            Pen pen2 = new Pen(Color.PaleVioletRed, 2);
            w = dx * (w / dx);
            h = dy * (h / dy);
            Point bottomRight = new Point(w, h);
            ////Нижний левый угол
            Point bottomLeft = new Point(0, h);
            ////Верхний правый угол
            Point topRight = new Point(w, 0);
            xa = xb;
            ya = yb;
            xb = xb + dx;
            yb = yb + dy;
            //Конечная точка
            Point lineStart = new Point(xb, yb);
            g.DrawLine(pen1, xa, ya, xb, yb);
            //Point line = line;
            //line(xb, yb);
            //Условие для вертикальной границы
            if (xb == start.X || xb == bottomRight.X)
            {
                dx *= -1;
            }
            ////Условие для горизонтальной границы
            if (yb == start.Y || yb == bottomRight.Y)
            {
                dy *= -1;
            }
            xa = xb;
            ya = yb;
            xb = xb + dx;
            yb = yb + dy;
            lineStart = new Point(xb, yb);
            g.DrawLine(pen2, xa, ya, xb, yb);
            if (xb == start.X || xb == bottomRight.X)
            {
                dx *= -1;
            }
            ////Условие для горизонтальной границы
            if (yb == start.Y || yb == bottomRight.Y)
            {
                dy *= -1;
            }
            if ((lineStart == start || lineStart == bottomRight || lineStart == bottomLeft || lineStart == topRight))
            {
                timer1.Stop();
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void frmFractalLP_anim_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFractalP thirt_form = new frmFractalP();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFractalP_2 thirt_form = new frmFractalP_2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }
    }
}
