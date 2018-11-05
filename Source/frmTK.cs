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
    public partial class frmTK : Form
    {
        private int n;
        private int w;
        private int h;
        private Bitmap serp;
        private Graphics g;
        public frmTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain thirt_form = new frmMain();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            w = pictureBox1.Width;
            h = pictureBox1.Height;
            n = (int)dmn_updown.Value;
            //Bitmap
            serp = new Bitmap(w, h);
            g = Graphics.FromImage(serp);
            //Квадрат и отрисовка
            RectangleF carpet = new RectangleF(0, 0, w, h);
            DrawCarpet(n, carpet);
            pictureBox1.BackgroundImage = serp;
            double kolvo_ost, kolvo_vil;
            kolvo_vil = (Math.Pow(8, n) - 1) / 7;
            kolvo_ost = Math.Pow(8, n);
            label5.Text = Convert.ToString("Кількість вилучених квадратів - " + kolvo_vil);
            label6.Text = Convert.ToString("Кількість залишившихся квадратів - " + kolvo_ost);
        }
        private void DrawCarpet(int n, RectangleF carpet)
        {
            //проверяем, закончили ли мы построение
            if (n == 0)
            {
                //Отрисовка
                g.FillRectangle(Brushes.Blue, carpet);
            }
            else
            {
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;
                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;
                DrawCarpet(n - 1, new RectangleF(x1, y1, width, height)); // левый 1(верхний)
                DrawCarpet(n - 1, new RectangleF(x2, y1, width, height)); // средний 1
                DrawCarpet(n - 1, new RectangleF(x3, y1, width, height)); // правый 1
                DrawCarpet(n - 1, new RectangleF(x1, y2, width, height)); // левый 2
                DrawCarpet(n - 1, new RectangleF(x3, y2, width, height)); // правый 2
                DrawCarpet(n - 1, new RectangleF(x1, y3, width, height)); // левый 3
                DrawCarpet(n - 1, new RectangleF(x2, y3, width, height)); // средний 3
                DrawCarpet(n - 1, new RectangleF(x3, y3, width, height)); // правый 3
            }
            pictureBox1.BackgroundImage = serp; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmPract thirt_form = new frmPract();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTK2 thirt_form = new frmTK2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
