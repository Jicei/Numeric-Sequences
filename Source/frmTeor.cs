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
    public partial class frmTeor : Form
    {
        public frmTeor()
        {
            InitializeComponent();
        }

        private void frmTeor_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            webBrowser1.Navigate(path + "\\texts\\1.htm");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeView1.SelectedNode.Text;
            int sqq = treeView1.SelectedNode.Index;
            if (st1 == "Числові послідовності. Основні поняття про числові послідовності")
            webBrowser1.Navigate(path + "\\texts\\1.htm");
            if (st1 == "Способи задання числових послідовностей")
            webBrowser1.Navigate(path + "\\texts\\2.htm");
            if (st1 == "Властивості числових послідовностей") 
            webBrowser1.Navigate(path + "\\texts\\3.htm");
            if (st1 == "Арифметична прогресія та їх властивості. Приклади арифметичних прогресій")
            webBrowser1.Navigate(path + "\\texts\\4.htm");
            if (st1 == "Геометрична прогресія")
            webBrowser1.Navigate(path + "\\texts\\5.htm");
            if (st1 == "Cніжинка Коха")
            webBrowser1.Navigate(path + "\\texts\\6.htm");
            if (st1 == "Трикутник Серпінського")
            webBrowser1.Navigate(path + "\\texts\\8.htm");
            if (st1 == "Килимок Серпинського")
            webBrowser1.Navigate(path + "\\texts\\10.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain thirt_form = new frmMain();
            thirt_form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            thirt_form.ShowDialog();
        }

        private void frmTeor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
