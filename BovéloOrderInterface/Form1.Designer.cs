namespace Bovelo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelOrder = new System.Windows.Forms.Panel();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.previewBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCatalog = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDelay = new System.Windows.Forms.Panel();
            this.delayInfobox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelRecap = new System.Windows.Forms.Panel();
            this.totalPriceTxt = new System.Windows.Forms.Label();
            this.recapTxt = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delayBtn = new System.Windows.Forms.Button();
            this.recapBtn = new System.Windows.Forms.Button();
            this.orderPageBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.catalogBtn = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.Bovelo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.panelCatalog.SuspendLayout();
            this.panelDelay.SuspendLayout();
            this.panelRecap.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.previewBox);
            this.panelOrder.Controls.Add(this.previewBtn);
            this.panelOrder.Controls.Add(this.label6);
            this.panelOrder.Controls.Add(this.addBtn);
            this.panelOrder.Controls.Add(this.quantityBox);
            this.panelOrder.Controls.Add(this.label5);
            this.panelOrder.Controls.Add(this.colorBox);
            this.panelOrder.Controls.Add(this.label4);
            this.panelOrder.Controls.Add(this.label3);
            this.panelOrder.Controls.Add(this.sizeBox);
            this.panelOrder.Controls.Add(this.modelBox);
            this.panelOrder.Controls.Add(this.label1);
            this.panelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelOrder.Location = new System.Drawing.Point(226, 58);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1097, 524);
            this.panelOrder.TabIndex = 14;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(439, 106);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(187, 94);
            this.previewBox.TabIndex = 30;
            this.previewBox.TabStop = false;
            // 
            // previewBtn
            // 
            this.previewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.previewBtn.FlatAppearance.BorderSize = 0;
            this.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.previewBtn.ForeColor = System.Drawing.Color.Black;
            this.previewBtn.Location = new System.Drawing.Point(608, 328);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(145, 45);
            this.previewBtn.TabIndex = 29;
            this.previewBtn.Text = "Preview bike";
            this.previewBtn.UseVisualStyleBackColor = false;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bovelo Order Page";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(789, 328);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 45);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Add item(s) to order";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(486, 345);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 20);
            this.quantityBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "quantity";
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.colorBox.Location = new System.Drawing.Point(231, 355);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 21);
            this.colorBox.TabIndex = 21;
            this.colorBox.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(99, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(100, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Size :";
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "26\"",
            "28\""});
            this.sizeBox.Location = new System.Drawing.Point(231, 310);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(121, 21);
            this.sizeBox.TabIndex = 18;
            this.sizeBox.Text = "26\"";
            // 
            // modelBox
            // 
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Items.AddRange(new object[] {
            "City",
            "Adventure",
            "Explorer"});
            this.modelBox.Location = new System.Drawing.Point(231, 271);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(121, 21);
            this.modelBox.TabIndex = 15;
            this.modelBox.Text = "City";
            this.modelBox.SelectedIndexChanged += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(88, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bike Models :";
            // 
            // panelCatalog
            // 
            this.panelCatalog.Controls.Add(this.label2);
            this.panelCatalog.Location = new System.Drawing.Point(226, 58);
            this.panelCatalog.Name = "panelCatalog";
            this.panelCatalog.Size = new System.Drawing.Size(1097, 521);
            this.panelCatalog.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Our Bikes";
            // 
            // panelDelay
            // 
            this.panelDelay.Controls.Add(this.delayInfobox);
            this.panelDelay.Controls.Add(this.label8);
            this.panelDelay.Location = new System.Drawing.Point(226, 58);
            this.panelDelay.Name = "panelDelay";
            this.panelDelay.Size = new System.Drawing.Size(1097, 524);
            this.panelDelay.TabIndex = 16;
            // 
            // delayInfobox
            // 
            this.delayInfobox.AutoSize = true;
            this.delayInfobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayInfobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.delayInfobox.Location = new System.Drawing.Point(220, 142);
            this.delayInfobox.Name = "delayInfobox";
            this.delayInfobox.Size = new System.Drawing.Size(16, 24);
            this.delayInfobox.TabIndex = 1;
            this.delayInfobox.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(582, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Order Delay informations";
            // 
            // panelRecap
            // 
            this.panelRecap.Controls.Add(this.totalPriceTxt);
            this.panelRecap.Controls.Add(this.recapTxt);
            this.panelRecap.Controls.Add(this.resetBtn);
            this.panelRecap.Controls.Add(this.confirmBtn);
            this.panelRecap.Controls.Add(this.label10);
            this.panelRecap.Controls.Add(this.label7);
            this.panelRecap.Location = new System.Drawing.Point(226, 58);
            this.panelRecap.Name = "panelRecap";
            this.panelRecap.Size = new System.Drawing.Size(1097, 524);
            this.panelRecap.TabIndex = 15;
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.AutoSize = true;
            this.totalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTxt.Location = new System.Drawing.Point(571, 314);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(0, 20);
            this.totalPriceTxt.TabIndex = 35;
            // 
            // recapTxt
            // 
            this.recapTxt.AutoSize = true;
            this.recapTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recapTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.recapTxt.Location = new System.Drawing.Point(452, 194);
            this.recapTxt.Name = "recapTxt";
            this.recapTxt.Size = new System.Drawing.Size(0, 25);
            this.recapTxt.TabIndex = 34;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(420, 366);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(150, 36);
            this.resetBtn.TabIndex = 33;
            this.resetBtn.Text = "Empty";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(589, 366);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(167, 36);
            this.confirmBtn.TabIndex = 31;
            this.confirmBtn.Text = "Confirm order";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order Recap Page";
            // 
            // delayBtn
            // 
            this.delayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.delayBtn.ForeColor = System.Drawing.Color.White;
            this.delayBtn.Image = ((System.Drawing.Image)(resources.GetObject("delayBtn.Image")));
            this.delayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delayBtn.Location = new System.Drawing.Point(3, 451);
            this.delayBtn.Name = "delayBtn";
            this.delayBtn.Padding = new System.Windows.Forms.Padding(5, 10, 2, 10);
            this.delayBtn.Size = new System.Drawing.Size(197, 78);
            this.delayBtn.TabIndex = 26;
            this.delayBtn.Text = "      Delay";
            this.delayBtn.UseVisualStyleBackColor = false;
            this.delayBtn.Click += new System.EventHandler(this.delayBtn_Click);
            // 
            // recapBtn
            // 
            this.recapBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.recapBtn.ForeColor = System.Drawing.Color.White;
            this.recapBtn.Image = ((System.Drawing.Image)(resources.GetObject("recapBtn.Image")));
            this.recapBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recapBtn.Location = new System.Drawing.Point(3, 341);
            this.recapBtn.Name = "recapBtn";
            this.recapBtn.Padding = new System.Windows.Forms.Padding(5, 10, 2, 10);
            this.recapBtn.Size = new System.Drawing.Size(197, 78);
            this.recapBtn.TabIndex = 25;
            this.recapBtn.Text = "    Recap";
            this.recapBtn.UseVisualStyleBackColor = false;
            this.recapBtn.Click += new System.EventHandler(this.recapBtn_Click);
            // 
            // orderPageBtn
            // 
            this.orderPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.orderPageBtn.ForeColor = System.Drawing.Color.White;
            this.orderPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("orderPageBtn.Image")));
            this.orderPageBtn.Location = new System.Drawing.Point(0, 238);
            this.orderPageBtn.Name = "orderPageBtn";
            this.orderPageBtn.Padding = new System.Windows.Forms.Padding(1, 10, 2, 10);
            this.orderPageBtn.Size = new System.Drawing.Size(200, 79);
            this.orderPageBtn.TabIndex = 27;
            this.orderPageBtn.Text = "    Order Page";
            this.orderPageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderPageBtn.UseVisualStyleBackColor = false;
            this.orderPageBtn.Click += new System.EventHandler(this.orderPageBtn_Click);
            // 
            // catalogBtn
            // 
            this.catalogBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.catalogBtn.ForeColor = System.Drawing.Color.White;
            this.catalogBtn.Image = ((System.Drawing.Image)(resources.GetObject("catalogBtn.Image")));
            this.catalogBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogBtn.Location = new System.Drawing.Point(0, 141);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Padding = new System.Windows.Forms.Padding(5, 10, 2, 10);
            this.catalogBtn.Size = new System.Drawing.Size(200, 76);
            this.catalogBtn.TabIndex = 28;
            this.catalogBtn.Text = "     Catalog";
            this.catalogBtn.UseVisualStyleBackColor = false;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelNav.Controls.Add(this.exitBtn);
            this.panelNav.Controls.Add(this.Bovelo);
            this.panelNav.Controls.Add(this.delayBtn);
            this.panelNav.Controls.Add(this.recapBtn);
            this.panelNav.Controls.Add(this.catalogBtn);
            this.panelNav.Controls.Add(this.orderPageBtn);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 675);
            this.panelNav.TabIndex = 29;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 568);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(200, 72);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "   Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Bovelo
            // 
            this.Bovelo.AutoSize = true;
            this.Bovelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bovelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Bovelo.ForeColor = System.Drawing.Color.White;
            this.Bovelo.Location = new System.Drawing.Point(12, 43);
            this.Bovelo.Name = "Bovelo";
            this.Bovelo.Size = new System.Drawing.Size(304, 60);
            this.Bovelo.TabIndex = 32;
            this.Bovelo.Text = "Bovelo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1226, 28);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1426, 675);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelRecap);
            this.Controls.Add(this.panelCatalog);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelDelay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Bovelo";
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.panelCatalog.ResumeLayout(false);
            this.panelCatalog.PerformLayout();
            this.panelDelay.ResumeLayout(false);
            this.panelDelay.PerformLayout();
            this.panelRecap.ResumeLayout(false);
            this.panelRecap.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delayBtn;
        private System.Windows.Forms.Button recapBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRecap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button orderPageBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button catalogBtn;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Bovelo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label recapTxt;
        private System.Windows.Forms.Label totalPriceTxt;
        private System.Windows.Forms.Label delayInfobox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.PictureBox previewBox;
    }
}
