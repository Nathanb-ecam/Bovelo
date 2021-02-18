namespace BovéloOrderInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDelay = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelRecap = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.totalPriceTxt = new System.Windows.Forms.RichTextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.recapTxt = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delayBtn = new System.Windows.Forms.Button();
            this.recapBtn = new System.Windows.Forms.Button();
            this.orderPageBtn = new System.Windows.Forms.Button();
            this.delayInfobox = new System.Windows.Forms.RichTextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDelay.SuspendLayout();
            this.panelRecap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.addBtn);
            this.panelMain.Controls.Add(this.quantityBox);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.colorBox);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.sizeBox);
            this.panelMain.Controls.Add(this.modelBox);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelMain.Location = new System.Drawing.Point(175, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(972, 381);
            this.panelMain.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F);
            this.label6.Location = new System.Drawing.Point(33, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bovélo Order Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 136);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(813, 208);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 23);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Add item(s) to order";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(706, 209);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 26);
            this.quantityBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
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
            this.colorBox.Location = new System.Drawing.Point(500, 206);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 28);
            this.colorBox.TabIndex = 21;
            this.colorBox.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Size :";
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "26\"",
            "28\""});
            this.sizeBox.Location = new System.Drawing.Point(306, 206);
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
            this.modelBox.Location = new System.Drawing.Point(104, 206);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(121, 28);
            this.modelBox.TabIndex = 15;
            this.modelBox.Text = "City";
            this.modelBox.SelectedIndexChanged += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bike Models :";
            // 
            // panelDelay
            // 
            this.panelDelay.Controls.Add(this.delayInfobox);
            this.panelDelay.Controls.Add(this.label8);
            this.panelDelay.Location = new System.Drawing.Point(175, 26);
            this.panelDelay.Name = "panelDelay";
            this.panelDelay.Size = new System.Drawing.Size(969, 381);
            this.panelDelay.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Order Delay informations";
            // 
            // panelRecap
            // 
            this.panelRecap.Controls.Add(this.resetBtn);
            this.panelRecap.Controls.Add(this.totalPriceTxt);
            this.panelRecap.Controls.Add(this.confirmBtn);
            this.panelRecap.Controls.Add(this.recapTxt);
            this.panelRecap.Controls.Add(this.label10);
            this.panelRecap.Controls.Add(this.label9);
            this.panelRecap.Controls.Add(this.label7);
            this.panelRecap.Location = new System.Drawing.Point(175, 29);
            this.panelRecap.Name = "panelRecap";
            this.panelRecap.Size = new System.Drawing.Size(972, 381);
            this.panelRecap.TabIndex = 15;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(37, 254);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(108, 36);
            this.resetBtn.TabIndex = 33;
            this.resetBtn.Text = "Reinitialiser";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.Location = new System.Drawing.Point(82, 208);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(125, 26);
            this.totalPriceTxt.TabIndex = 32;
            this.totalPriceTxt.Text = "";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(164, 254);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(125, 36);
            this.confirmBtn.TabIndex = 31;
            this.confirmBtn.Text = "Confirm order";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // recapTxt
            // 
            this.recapTxt.Location = new System.Drawing.Point(23, 70);
            this.recapTxt.Name = "recapTxt";
            this.recapTxt.Size = new System.Drawing.Size(229, 119);
            this.recapTxt.TabIndex = 30;
            this.recapTxt.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Order Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order Recap Page";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // delayBtn
            // 
            this.delayBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delayBtn.Location = new System.Drawing.Point(18, 237);
            this.delayBtn.Name = "delayBtn";
            this.delayBtn.Size = new System.Drawing.Size(98, 54);
            this.delayBtn.TabIndex = 26;
            this.delayBtn.Text = "View order delay";
            this.delayBtn.UseVisualStyleBackColor = false;
            this.delayBtn.Click += new System.EventHandler(this.delayBtn_Click);
            // 
            // recapBtn
            // 
            this.recapBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.recapBtn.Location = new System.Drawing.Point(18, 148);
            this.recapBtn.Name = "recapBtn";
            this.recapBtn.Size = new System.Drawing.Size(98, 56);
            this.recapBtn.TabIndex = 25;
            this.recapBtn.Text = "Order recap";
            this.recapBtn.UseVisualStyleBackColor = false;
            this.recapBtn.Click += new System.EventHandler(this.recapBtn_Click);
            // 
            // orderPageBtn
            // 
            this.orderPageBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orderPageBtn.Location = new System.Drawing.Point(18, 66);
            this.orderPageBtn.Name = "orderPageBtn";
            this.orderPageBtn.Size = new System.Drawing.Size(98, 52);
            this.orderPageBtn.TabIndex = 27;
            this.orderPageBtn.Text = "Order Page";
            this.orderPageBtn.UseVisualStyleBackColor = false;
            this.orderPageBtn.Click += new System.EventHandler(this.orderPageBtn_Click);
            // 
            // delayInfobox
            // 
            this.delayInfobox.Location = new System.Drawing.Point(49, 73);
            this.delayInfobox.Name = "delayInfobox";
            this.delayInfobox.Size = new System.Drawing.Size(348, 158);
            this.delayInfobox.TabIndex = 1;
            this.delayInfobox.Text = "";
            this.delayInfobox.TextChanged += new System.EventHandler(this.delayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 632);
            this.Controls.Add(this.orderPageBtn);
            this.Controls.Add(this.panelDelay);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRecap);
            this.Controls.Add(this.delayBtn);
            this.Controls.Add(this.recapBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDelay.ResumeLayout(false);
            this.panelDelay.PerformLayout();
            this.panelRecap.ResumeLayout(false);
            this.panelRecap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox totalPriceTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.RichTextBox recapTxt;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.RichTextBox delayInfobox;
    }
}

