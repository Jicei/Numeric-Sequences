namespace Меню
{
    partial class frmTeor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Способи задання числових послідовностей");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Властивості числових послідовностей");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Арифметична прогресія та їх властивості. Приклади арифметичних прогресій");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Геометрична прогресія");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cніжинка Коха");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Трикутник Серпінського");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Килимок Серпинського");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Числові послідовності. Основні поняття про числові послідовності", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(199, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 484);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(24, 24);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(637, 484);
            this.webBrowser1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 13);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Способи задання числових послідовностей";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Властивості числових послідовностей";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "Арифметична прогресія та їх властивості. Приклади арифметичних прогресій";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Геометрична прогресія";
            treeNode5.Name = "Узел5";
            treeNode5.Text = "Cніжинка Коха";
            treeNode6.Name = "Узел7";
            treeNode6.Text = "Трикутник Серпінського";
            treeNode7.Name = "Узел9";
            treeNode7.Text = "Килимок Серпинського";
            treeNode8.Name = "Узел0";
            treeNode8.Text = "Числові послідовності. Основні поняття про числові послідовності";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(181, 382);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(7, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTeor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTeor";
            this.Text = "Теоретична частина";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTeor_FormClosed);
            this.Load += new System.EventHandler(this.frmTeor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}