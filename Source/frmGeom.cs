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
    public partial class frmGeom : Form
    {
        public frmGeom()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMain thirt_form = new frmMain();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmG1 thirt_form = new frmG1();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmG2 thirt_form = new frmG2();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmG4 thirt_form = new frmG4();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmG3 thirt_form = new frmG3();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            frmG6 thirt_form = new frmG6();
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

        private void frmGeom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
