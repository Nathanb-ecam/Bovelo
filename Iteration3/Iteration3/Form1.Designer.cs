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
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.connectTxt = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.general = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.Button();
            this.explorer = new System.Windows.Forms.Button();
            this.adventure = new System.Windows.Forms.Button();
            this.generalList = new System.Windows.Forms.NumericUpDown();
            this.cityList = new System.Windows.Forms.NumericUpDown();
            this.explorerList = new System.Windows.Forms.NumericUpDown();
            this.adventureList = new System.Windows.Forms.NumericUpDown();
            this.confirm = new System.Windows.Forms.Button();
            this.refillAll = new System.Windows.Forms.Button();
            this.refillMin = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.largeRefill = new System.Windows.Forms.Button();
            this.mediumRefill = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.connectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureList)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(268, 42);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(277, 31);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Gestionnaire de stock";
            // 
            // stockGrid
            // 
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Location = new System.Drawing.Point(183, 112);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.ReadOnly = true;
            this.stockGrid.Size = new System.Drawing.Size(446, 237);
            this.stockGrid.TabIndex = 2;
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.connectTxt);
            this.connectionPanel.Controls.Add(this.connect);
            this.connectionPanel.Controls.Add(this.password);
            this.connectionPanel.Controls.Add(this.user);
            this.connectionPanel.Controls.Add(this.label2);
            this.connectionPanel.Controls.Add(this.label1);
            this.connectionPanel.Location = new System.Drawing.Point(0, 0);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(801, 451);
            this.connectionPanel.TabIndex = 3;
            // 
            // connectTxt
            // 
            this.connectTxt.AutoSize = true;
            this.connectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectTxt.Location = new System.Drawing.Point(291, 318);
            this.connectTxt.Name = "connectTxt";
            this.connectTxt.Size = new System.Drawing.Size(0, 31);
            this.connectTxt.TabIndex = 5;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(503, 157);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(126, 52);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(297, 208);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(297, 136);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User : ";
            // 
            // general
            // 
            this.general.Location = new System.Drawing.Point(12, 112);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(96, 34);
            this.general.TabIndex = 6;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(12, 175);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(96, 34);
            this.city.TabIndex = 7;
            this.city.Text = "City";
            this.city.UseVisualStyleBackColor = true;
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // explorer
            // 
            this.explorer.Location = new System.Drawing.Point(12, 245);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(96, 34);
            this.explorer.TabIndex = 8;
            this.explorer.Text = "Explorer";
            this.explorer.UseVisualStyleBackColor = true;
            this.explorer.Click += new System.EventHandler(this.explorer_Click);
            // 
            // adventure
            // 
            this.adventure.Location = new System.Drawing.Point(12, 315);
            this.adventure.Name = "adventure";
            this.adventure.Size = new System.Drawing.Size(96, 34);
            this.adventure.TabIndex = 9;
            this.adventure.Text = "Adventure";
            this.adventure.UseVisualStyleBackColor = true;
            this.adventure.Click += new System.EventHandler(this.adventure_Click);
            // 
            // generalList
            // 
            this.generalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalList.Location = new System.Drawing.Point(114, 116);
            this.generalList.Name = "generalList";
            this.generalList.Size = new System.Drawing.Size(46, 27);
            this.generalList.TabIndex = 16;
            // 
            // cityList
            // 
            this.cityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityList.Location = new System.Drawing.Point(114, 179);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(46, 27);
            this.cityList.TabIndex = 19;
            // 
            // explorerList
            // 
            this.explorerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorerList.Location = new System.Drawing.Point(114, 249);
            this.explorerList.Name = "explorerList";
            this.explorerList.Size = new System.Drawing.Size(46, 27);
            this.explorerList.TabIndex = 20;
            // 
            // adventureList
            // 
            this.adventureList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adventureList.Location = new System.Drawing.Point(114, 318);
            this.adventureList.Name = "adventureList";
            this.adventureList.Size = new System.Drawing.Size(46, 27);
            this.adventureList.TabIndex = 21;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.confirm.Location = new System.Drawing.Point(662, 385);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(96, 34);
            this.confirm.TabIndex = 22;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // refillAll
            // 
            this.refillAll.Location = new System.Drawing.Point(662, 315);
            this.refillAll.Name = "refillAll";
            this.refillAll.Size = new System.Drawing.Size(96, 34);
            this.refillAll.TabIndex = 23;
            this.refillAll.Text = "Custom";
            this.refillAll.UseVisualStyleBackColor = true;
            this.refillAll.Click += new System.EventHandler(this.refillAll_Click);
            // 
            // refillMin
            // 
            this.refillMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.refillMin.Location = new System.Drawing.Point(662, 112);
            this.refillMin.Name = "refillMin";
            this.refillMin.Size = new System.Drawing.Size(96, 33);
            this.refillMin.TabIndex = 24;
            this.refillMin.Text = "Minimum";
            this.refillMin.UseVisualStyleBackColor = false;
            this.refillMin.Click += new System.EventHandler(this.refillMin_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(180, 385);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            this.info.TabIndex = 25;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset.Location = new System.Drawing.Point(12, 385);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 34);
            this.reset.TabIndex = 26;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // largeRefill
            // 
            this.largeRefill.Location = new System.Drawing.Point(662, 245);
            this.largeRefill.Name = "largeRefill";
            this.largeRefill.Size = new System.Drawing.Size(96, 34);
            this.largeRefill.TabIndex = 27;
            this.largeRefill.Text = "Large";
            this.largeRefill.UseVisualStyleBackColor = true;
            this.largeRefill.Click += new System.EventHandler(this.largeRefill_Click);
            // 
            // mediumRefill
            // 
            this.mediumRefill.Location = new System.Drawing.Point(662, 175);
            this.mediumRefill.Name = "mediumRefill";
            this.mediumRefill.Size = new System.Drawing.Size(96, 34);
            this.mediumRefill.TabIndex = 28;
            this.mediumRefill.Text = "Medium";
            this.mediumRefill.UseVisualStyleBackColor = true;
            this.mediumRefill.Click += new System.EventHandler(this.mediumRefill_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(12, 20);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(96, 34);
            this.disconnect.TabIndex = 29;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(662, 20);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(96, 34);
            this.refresh.TabIndex = 30;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.mediumRefill);
            this.Controls.Add(this.largeRefill);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.info);
            this.Controls.Add(this.refillMin);
            this.Controls.Add(this.refillAll);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.adventureList);
            this.Controls.Add(this.explorerList);
            this.Controls.Add(this.cityList);
            this.Controls.Add(this.generalList);
            this.Controls.Add(this.adventure);
            this.Controls.Add(this.explorer);
            this.Controls.Add(this.city);
            this.Controls.Add(this.general);
            this.Controls.Add(this.stockGrid);
            this.Controls.Add(this.tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectTxt;
        private System.Windows.Forms.Button general;
        private System.Windows.Forms.Button city;
        private System.Windows.Forms.Button explorer;
        private System.Windows.Forms.Button adventure;
        private System.Windows.Forms.NumericUpDown generalList;
        private System.Windows.Forms.NumericUpDown cityList;
        private System.Windows.Forms.NumericUpDown explorerList;
        private System.Windows.Forms.NumericUpDown adventureList;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button refillAll;
        private System.Windows.Forms.Button refillMin;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button largeRefill;
        private System.Windows.Forms.Button mediumRefill;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button refresh;
    }
}

