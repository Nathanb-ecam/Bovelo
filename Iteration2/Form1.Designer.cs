namespace BOVELO_PlanningList
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jaiFinisMaTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeCommenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBananasAreRipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(231, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Planning List";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 490);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes commandes";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1581, 458);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "idBike";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            this.columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Color";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Size";
            this.columnHeader10.Width = 142;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Monteur";
            this.columnHeader11.Width = 188;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Horaire tache";
            this.columnHeader12.Width = 242;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Durée tache";
            this.columnHeader1.Width = 227;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jaiFinisMaTacheToolStripMenuItem,
            this.jeCommenceToolStripMenuItem,
            this.myBananasAreRipeToolStripMenuItem,
            this.ajoutCommandeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 100);
            // 
            // jaiFinisMaTacheToolStripMenuItem
            // 
            this.jaiFinisMaTacheToolStripMenuItem.Name = "jaiFinisMaTacheToolStripMenuItem";
            this.jaiFinisMaTacheToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.jaiFinisMaTacheToolStripMenuItem.Text = "Finished work";
            this.jaiFinisMaTacheToolStripMenuItem.Click += new System.EventHandler(this.jaiFinisMaTacheToolStripMenuItem_Click);
            // 
            // jeCommenceToolStripMenuItem
            // 
            this.jeCommenceToolStripMenuItem.Name = "jeCommenceToolStripMenuItem";
            this.jeCommenceToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.jeCommenceToolStripMenuItem.Text = "Start work";
            this.jeCommenceToolStripMenuItem.Click += new System.EventHandler(this.jeCommenceToolStripMenuItem_Click);
            // 
            // myBananasAreRipeToolStripMenuItem
            // 
            this.myBananasAreRipeToolStripMenuItem.Name = "myBananasAreRipeToolStripMenuItem";
            this.myBananasAreRipeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.myBananasAreRipeToolStripMenuItem.Text = "Modifier et détail";
            this.myBananasAreRipeToolStripMenuItem.Click += new System.EventHandler(this.myBananasAreRipeToolStripMenuItem_Click);
            // 
            // ajoutCommandeToolStripMenuItem
            // 
            this.ajoutCommandeToolStripMenuItem.Name = "ajoutCommandeToolStripMenuItem";
            this.ajoutCommandeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.ajoutCommandeToolStripMenuItem.Text = "Ajout commande";
            this.ajoutCommandeToolStripMenuItem.Click += new System.EventHandler(this.ajoutCommandeToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(897, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Actualiser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimeIsOn);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1123, 588);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jaiFinisMaTacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeCommenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myBananasAreRipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutCommandeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
    }
}

