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
    public partial class frmKoxa : Form
    {
        //static Pen pen1;
        static Graphics g;
        //static Pen pen2;
        static int n;
        public frmKoxa()
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
            double l, s0, s, n1, T;
            l = (int)numericUpDown1.Value;
            n = (int)dmn_updown.Value;
            s0 = (Math.Sqrt(3) / 4) * l*l;
            label1.Text = Convert.ToString("Стартова площа - " + Math.Round(s0, 2));
            s =  s0*8/5;
            label2.Text = Convert.ToString("Площа фігури - " + Math.Round(s, 2));
            n1 = Convert.ToDouble(n);
            T = (3 * Math.Pow(4, n1 - 2));
            label3.Text = Convert.ToString("Кількість фігур зовні на n-ому кроці - " + T);
            if (n < 2)
            {
                label2.Text = Convert.ToString("Площа фігури - " + Math.Round(s0,2));
                label3.Text = Convert.ToString("Кількість фігур зовні на n-ому кроці - " + 1);
            }
            Pen pen1 = new Pen(Color.Green, 1);
            Pen pen2 = new Pen(Color.Blue, 1);
            g = pictureBox1.CreateGraphics();
            this.Refresh();
            //Координаты
            point1 = new PointF(60, 350);
            point2 = new PointF(560, 350);
            point3 = new PointF(310, 50);
            //отрисовка
            g.DrawLine(pen1, point1, point2);
            g.DrawLine(pen1, point2, point3);
            g.DrawLine(pen1, point3, point1);
            Thread p = new Thread(t1);
            p.Start();
        }
        private static PointF point1, point2, point3;

        private void button8_Click(object sender, EventArgs e)
        {
            frmPract thirt_form = new frmPract();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private static void t1()
        {
            //рисовка на сторонах треугольника
            Draw(point1, point2, point3, n - 1);
            Draw(point2, point3, point1, n - 1);
            Draw(point3, point1, point2, n - 1);
        }


        static int Draw(PointF p1, PointF p2, PointF p3, int iter)
        {
            try
            {
                Pen pen1 = new Pen(Color.Green, 1);
                Pen pen2 = new Pen(Color.Blue, 1);
                if (iter > 0)
                {
                    //средняя треть отрезка
                    var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                    var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                    //координаты вершины угла
                    var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                    var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                    //отрисовка
                    g.DrawLine(pen1, p4, pn);
                    g.DrawLine(pen1, p5, pn);
                    g.DrawLine(pen2, p4, p5);
                    Thread.Sleep(100);
                    //Количество раз
                    Draw(p4, pn, p5, iter - 1);
                    Draw(pn, p5, p4, iter - 1);
                    Draw(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1);
                    Draw(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1);

                }
                return iter;
            }
            catch { return 0; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKoxa2 thirt_form = new frmKoxa2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            thirt_form.Show();
        }

        private void frmKoxa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
