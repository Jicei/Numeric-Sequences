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
    public partial class frmFractalP : Form
    {
        Point start = new Point(0, 0);
        Point lineStart;
        int w;
        int h;
        int dx, dy, xa, xb, ya, yb;
        Pen pen3 = new Pen(Color.Tomato, 2);
        Graphics g;
        public frmFractalP()
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

        private void button8_Click(object sender, EventArgs e)
        {
            frmPract thirt_form = new frmPract();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFractalLP_anim thirt_form = new frmFractalLP_anim();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
                this.Refresh();
                SolidBrush b = new SolidBrush(Color.PaleVioletRed);
                g = pictureBox1.CreateGraphics();
                dx = int.Parse(domainUpDown1.Text);
                dy = int.Parse(domainUpDown2.Text);
                xa = -dx; ya = -dy; xb = 0; yb = 0;
               if(dx<1)
                {
                    dx = 1;
                    domainUpDown1.Value = 1;
                }
                if(dy<1)
                {
                dy = 1;
                domainUpDown2.Value = 1;
                }
                w = e.X+dx;
                h = e.Y+dy;

                g.FillRectangle(b, 0, 0, w, h);
                g.DrawRectangle(pen3, 0, 0, w, h);
                Pen pen1 = new Pen(Color.White, 2);
                Pen pen2 = new Pen(Color.PaleVioletRed, 2);
                w = dx * (w / dx);
                h = dy * (h / dy);
                //Нижний правый угол
                Point bottomRight = new Point(w, h);
                ////Нижний левый угол
                Point bottomLeft = new Point(0, h);
                ////Верхний правый угол
                Point topRight = new Point(w, 0);
                //Point line = line;
                //line(xb, yb);
 
                    do
                    {
                        xa = xb;
                        ya = yb;
                        xb = xb + dx;
                        yb = yb + dy;
                        //Конечная точка
                        lineStart = new Point(xb, yb);
                        g.DrawLine(pen1, xa, ya, xb, yb);
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
                    } while (!(lineStart == start || lineStart == bottomRight || lineStart == bottomLeft || lineStart == topRight));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
        }

        private void frmFractalP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFractalP_2 thirt_form = new frmFractalP_2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }
      }
    }
