﻿namespace Bovelo
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panelRecap = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendOrderBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.totalPriceTxt = new System.Windows.Forms.Label();
            this.recapTxt = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCatalog = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDelay = new System.Windows.Forms.Panel();
            this.delayInfobox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panelRecap.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCatalog.SuspendLayout();
            this.panelDelay.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.priceLabel);
            this.panelOrder.Controls.Add(this.label9);
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
            this.panelOrder.Location = new System.Drawing.Point(276, 61);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1214, 613);
            this.panelOrder.TabIndex = 14;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(769, 368);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(15, 22);
            this.priceLabel.TabIndex = 30;
            this.priceLabel.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(673, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Item(s) price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 47);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bovelo Order Page";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(665, 310);
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
            this.quantityBox.Size = new System.Drawing.Size(100, 26);
            this.quantityBox.TabIndex = 23;
            this.quantityBox.TextChanged += new System.EventHandler(this.quantityBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "quantity";
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black"});
            this.colorBox.Location = new System.Drawing.Point(231, 355);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 28);
            this.colorBox.TabIndex = 21;
            this.colorBox.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 37);
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
            this.sizeBox.Size = new System.Drawing.Size(121, 28);
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
            this.modelBox.Size = new System.Drawing.Size(121, 28);
            this.modelBox.TabIndex = 15;
            this.modelBox.Text = "City";
            this.modelBox.SelectedIndexChanged += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bike Models :";
            // 
            // panelRecap
            // 
            this.panelRecap.Controls.Add(this.panel1);
            this.panelRecap.Controls.Add(this.totalPriceTxt);
            this.panelRecap.Controls.Add(this.recapTxt);
            this.panelRecap.Controls.Add(this.resetBtn);
            this.panelRecap.Controls.Add(this.confirmBtn);
            this.panelRecap.Controls.Add(this.label10);
            this.panelRecap.Controls.Add(this.label7);
            this.panelRecap.Location = new System.Drawing.Point(276, 61);
            this.panelRecap.Name = "panelRecap";
            this.panelRecap.Size = new System.Drawing.Size(1214, 613);
            this.panelRecap.TabIndex = 15;
            this.panelRecap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecap_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendOrderBtn);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.adressBox);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 613);
            this.panel1.TabIndex = 36;
            // 
            // sendOrderBtn
            // 
            this.sendOrderBtn.Location = new System.Drawing.Point(445, 314);
            this.sendOrderBtn.Name = "sendOrderBtn";
            this.sendOrderBtn.Size = new System.Drawing.Size(126, 43);
            this.sendOrderBtn.TabIndex = 6;
            this.sendOrderBtn.Text = "Send Order";
            this.sendOrderBtn.UseVisualStyleBackColor = true;
            this.sendOrderBtn.Click += new System.EventHandler(this.sendOrderBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(391, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Adress :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(367, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "Phone number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name :";
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(487, 256);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(100, 26);
            this.adressBox.TabIndex = 2;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(486, 203);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 26);
            this.phoneBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(486, 146);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 26);
            this.nameBox.TabIndex = 0;
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.AutoSize = true;
            this.totalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTxt.Location = new System.Drawing.Point(571, 314);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(0, 29);
            this.totalPriceTxt.TabIndex = 35;
            // 
            // recapTxt
            // 
            this.recapTxt.AutoSize = true;
            this.recapTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recapTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.recapTxt.Location = new System.Drawing.Point(452, 194);
            this.recapTxt.Name = "recapTxt";
            this.recapTxt.Size = new System.Drawing.Size(0, 37);
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
            this.confirmBtn.Text = "Continue";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 37);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order Recap Page";
            // 
            // panelCatalog
            // 
            this.panelCatalog.Controls.Add(this.label2);
            this.panelCatalog.Location = new System.Drawing.Point(276, 67);
            this.panelCatalog.Name = "panelCatalog";
            this.panelCatalog.Size = new System.Drawing.Size(1214, 613);
            this.panelCatalog.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Our Bikes";
            // 
            // panelDelay
            // 
            this.panelDelay.Controls.Add(this.delayInfobox);
            this.panelDelay.Controls.Add(this.label8);
            this.panelDelay.Location = new System.Drawing.Point(276, 67);
            this.panelDelay.Name = "panelDelay";
            this.panelDelay.Size = new System.Drawing.Size(1214, 613);
            this.panelDelay.TabIndex = 16;
            // 
            // delayInfobox
            // 
            this.delayInfobox.AutoSize = true;
            this.delayInfobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayInfobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.delayInfobox.Location = new System.Drawing.Point(220, 142);
            this.delayInfobox.Name = "delayInfobox";
            this.delayInfobox.Size = new System.Drawing.Size(25, 33);
            this.delayInfobox.TabIndex = 1;
            this.delayInfobox.Text = "-";
            this.delayInfobox.Click += new System.EventHandler(this.delayInfobox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(481, 47);
            this.label8.TabIndex = 0;
            this.label8.Text = "Order Delay informations";
            // 
            // delayBtn
            // 
            this.delayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.recapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.orderPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.catalogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelNav.Size = new System.Drawing.Size(200, 822);
            this.panelNav.TabIndex = 29;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Bovelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bovelo.ForeColor = System.Drawing.Color.White;
            this.Bovelo.Location = new System.Drawing.Point(12, 43);
            this.Bovelo.Name = "Bovelo";
            this.Bovelo.Size = new System.Drawing.Size(283, 93);
            this.Bovelo.TabIndex = 32;
            this.Bovelo.Text = "Bovelo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1382, 28);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 822);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelRecap);
            this.Controls.Add(this.panelDelay);
            this.Controls.Add(this.panelCatalog);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelNav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Bovelo";
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.panelRecap.ResumeLayout(false);
            this.panelRecap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCatalog.ResumeLayout(false);
            this.panelCatalog.PerformLayout();
            this.panelDelay.ResumeLayout(false);
            this.panelDelay.PerformLayout();
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
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendOrderBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}
