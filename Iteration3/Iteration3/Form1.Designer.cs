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
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(268, 42);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(191, 24);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Gestionnaire de stock";
            // 
            // refillBtn
            // 
            this.refillBtn.Location = new System.Drawing.Point(602, 383);
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
            this.stockGrid.Location = new System.Drawing.Point(166, 112);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.Size = new System.Drawing.Size(481, 237);
            this.stockGrid.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockGrid);
            this.Controls.Add(this.refillBtn);
            this.Controls.Add(this.tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button refillBtn;
        private System.Windows.Forms.DataGridView stockGrid;
    }
}

