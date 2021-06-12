namespace Iteration3
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
            this.tittle = new System.Windows.Forms.Label();
            this.refillBtn = new System.Windows.Forms.Button();
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.CityStock = new System.Windows.Forms.Button();
            this.AdventureStock = new System.Windows.Forms.Button();
            this.ExplorerStock = new System.Windows.Forms.Button();
            this.GeneralStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.applyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(453, 50);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(197, 25);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Stock Management";
            // 
            // refillBtn
            // 
            this.refillBtn.Location = new System.Drawing.Point(965, 291);
            this.refillBtn.Name = "refillBtn";
            this.refillBtn.Size = new System.Drawing.Size(111, 34);
            this.refillBtn.TabIndex = 1;
            this.refillBtn.Text = "Refill stock";
            this.refillBtn.UseVisualStyleBackColor = true;
            this.refillBtn.Click += new System.EventHandler(this.refillBtn_Click);
            // 
            // stockGrid
            // 
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Location = new System.Drawing.Point(218, 119);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.Size = new System.Drawing.Size(682, 370);
            this.stockGrid.TabIndex = 2;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(171, 74);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(44, 20);
            this.quantityBox.TabIndex = 3;
            // 
            // CityStock
            // 
            this.CityStock.Location = new System.Drawing.Point(39, 208);
            this.CityStock.Name = "CityStock";
            this.CityStock.Size = new System.Drawing.Size(154, 23);
            this.CityStock.TabIndex = 4;
            this.CityStock.Text = "City Stock";
            this.CityStock.UseVisualStyleBackColor = true;
            this.CityStock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // AdventureStock
            // 
            this.AdventureStock.Location = new System.Drawing.Point(36, 247);
            this.AdventureStock.Name = "AdventureStock";
            this.AdventureStock.Size = new System.Drawing.Size(157, 23);
            this.AdventureStock.TabIndex = 5;
            this.AdventureStock.Text = "Adventure Stock";
            this.AdventureStock.UseVisualStyleBackColor = true;
            this.AdventureStock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // ExplorerStock
            // 
            this.ExplorerStock.Location = new System.Drawing.Point(36, 291);
            this.ExplorerStock.Name = "ExplorerStock";
            this.ExplorerStock.Size = new System.Drawing.Size(157, 23);
            this.ExplorerStock.TabIndex = 6;
            this.ExplorerStock.Text = "Explorer Stock";
            this.ExplorerStock.UseVisualStyleBackColor = true;
            this.ExplorerStock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // GeneralStock
            // 
            this.GeneralStock.Location = new System.Drawing.Point(36, 330);
            this.GeneralStock.Name = "GeneralStock";
            this.GeneralStock.Size = new System.Drawing.Size(157, 23);
            this.GeneralStock.TabIndex = 7;
            this.GeneralStock.Text = "GeneralStock";
            this.GeneralStock.UseVisualStyleBackColor = true;
            this.GeneralStock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "View Tables :";
            // 
            // modelBox
            // 
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Items.AddRange(new object[] {
            "City",
            "Adventure",
            "Explorer",
            "General"});
            this.modelBox.Location = new System.Drawing.Point(10, 74);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(121, 21);
            this.modelBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Increase all parts of a specific type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applyBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.quantityBox);
            this.groupBox1.Location = new System.Drawing.Point(381, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick refill";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(249, 72);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 12;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeneralStock);
            this.Controls.Add(this.ExplorerStock);
            this.Controls.Add(this.AdventureStock);
            this.Controls.Add(this.CityStock);
            this.Controls.Add(this.stockGrid);
            this.Controls.Add(this.refillBtn);
            this.Controls.Add(this.tittle);
            this.Name = "Form1";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button refillBtn;
        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Button CityStock;
        private System.Windows.Forms.Button AdventureStock;
        private System.Windows.Forms.Button ExplorerStock;
        private System.Windows.Forms.Button GeneralStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button applyBtn;
    }
}

