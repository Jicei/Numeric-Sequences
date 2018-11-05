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
    public partial class frmPract : Form
    {
        public frmPract()
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
            frmKoxa thirt_form = new frmKoxa();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTS thirt_form = new frmTS();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTK thirt_form = new frmTK();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGeom thirt_form = new frmGeom();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmFractalP thirt_form = new frmFractalP();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void frmPract_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
