namespace GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvisionnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remboursementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiquesESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dépensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDépensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDépenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 49);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::GUI.Properties.Resources.Delete_48px;
            this.button8.Location = new System.Drawing.Point(1322, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 41);
            this.button8.TabIndex = 11;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.approvisionnementToolStripMenuItem,
            this.venteToolStripMenuItem,
            this.stockToolStripMenuItem2,
            this.databaseManagerToolStripMenuItem,
            this.userToolStripMenuItem,
            this.dépensesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.readMeToolStripMenuItem,
            this.licenceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aProposToolStripMenuItem,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::GUI.Properties.Resources.Home_40px;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.fileToolStripMenuItem.Text = "Home";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItem1.Text = "Accueil";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Image = global::GUI.Properties.Resources.Information_48px;
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.readMeToolStripMenuItem.Text = "ReadMe";
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Image = global::GUI.Properties.Resources.Medal_48px;
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.licenceToolStripMenuItem.Text = "Licence";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItem2.Text = "Maison";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Image = global::GUI.Properties.Resources.Info_48px;
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Image = global::GUI.Properties.Resources.Delete_48px;
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // approvisionnementToolStripMenuItem
            // 
            this.approvisionnementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem,
            this.catégorieToolStripMenuItem});
            this.approvisionnementToolStripMenuItem.Image = global::GUI.Properties.Resources.Shopping_Cart_Loaded_48px;
            this.approvisionnementToolStripMenuItem.Name = "approvisionnementToolStripMenuItem";
            this.approvisionnementToolStripMenuItem.Size = new System.Drawing.Size(192, 25);
            this.approvisionnementToolStripMenuItem.Text = "Approvisionnement";
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.Image = global::GUI.Properties.Resources.Add_Shopping_Cart_48px;
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.articlesToolStripMenuItem.Text = "New Approvisionnnement";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.Image = global::GUI.Properties.Resources.Shopping_Cart_Loaded_48px;
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.catégorieToolStripMenuItem.Text = "All Approvisionnement";
            this.catégorieToolStripMenuItem.Click += new System.EventHandler(this.catégorieToolStripMenuItem_Click);
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleVenteToolStripMenuItem,
            this.toutesLesVentesToolStripMenuItem,
            this.remboursementToolStripMenuItem});
            this.venteToolStripMenuItem.Image = global::GUI.Properties.Resources.Buy_48px;
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.venteToolStripMenuItem.Text = "Vente";
            // 
            // nouvelleVenteToolStripMenuItem
            // 
            this.nouvelleVenteToolStripMenuItem.Image = global::GUI.Properties.Resources.Add_Shopping_Cart_48px;
            this.nouvelleVenteToolStripMenuItem.Name = "nouvelleVenteToolStripMenuItem";
            this.nouvelleVenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.nouvelleVenteToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.nouvelleVenteToolStripMenuItem.Text = "Nouvelle vente";
            this.nouvelleVenteToolStripMenuItem.Click += new System.EventHandler(this.nouvelleVenteToolStripMenuItem_Click);
            // 
            // toutesLesVentesToolStripMenuItem
            // 
            this.toutesLesVentesToolStripMenuItem.Image = global::GUI.Properties.Resources.Shopping_Cart_Loaded_48px;
            this.toutesLesVentesToolStripMenuItem.Name = "toutesLesVentesToolStripMenuItem";
            this.toutesLesVentesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
            this.toutesLesVentesToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.toutesLesVentesToolStripMenuItem.Text = "Toutes les ventes";
            this.toutesLesVentesToolStripMenuItem.Click += new System.EventHandler(this.toutesLesVentesToolStripMenuItem_Click);
            // 
            // remboursementToolStripMenuItem
            // 
            this.remboursementToolStripMenuItem.Name = "remboursementToolStripMenuItem";
            this.remboursementToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.remboursementToolStripMenuItem.Text = "Remboursement";
            this.remboursementToolStripMenuItem.Click += new System.EventHandler(this.remboursementToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem2
            // 
            this.stockToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem1,
            this.catégoriesToolStripMenuItem,
            this.historiquesESToolStripMenuItem});
            this.stockToolStripMenuItem2.Image = global::GUI.Properties.Resources.Box_48px;
            this.stockToolStripMenuItem2.Name = "stockToolStripMenuItem2";
            this.stockToolStripMenuItem2.Size = new System.Drawing.Size(81, 25);
            this.stockToolStripMenuItem2.Text = "Stock";
            this.stockToolStripMenuItem2.Click += new System.EventHandler(this.stockToolStripMenuItem2_Click);
            // 
            // articlesToolStripMenuItem1
            // 
            this.articlesToolStripMenuItem1.Image = global::GUI.Properties.Resources.Price_Tag_48px;
            this.articlesToolStripMenuItem1.Name = "articlesToolStripMenuItem1";
            this.articlesToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.articlesToolStripMenuItem1.Text = "Articles";
            this.articlesToolStripMenuItem1.Click += new System.EventHandler(this.articlesToolStripMenuItem1_Click);
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Image = global::GUI.Properties.Resources.Categorize_48px;
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.catégoriesToolStripMenuItem_Click);
            // 
            // historiquesESToolStripMenuItem
            // 
            this.historiquesESToolStripMenuItem.Image = global::GUI.Properties.Resources.Sell_Stock_48px;
            this.historiquesESToolStripMenuItem.Name = "historiquesESToolStripMenuItem";
            this.historiquesESToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.historiquesESToolStripMenuItem.Text = "Historiques ES";
            this.historiquesESToolStripMenuItem.Click += new System.EventHandler(this.historiquesESToolStripMenuItem_Click);
            // 
            // databaseManagerToolStripMenuItem
            // 
            this.databaseManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.databaseManagerToolStripMenuItem.Image = global::GUI.Properties.Resources.Database_Administrator_48px;
            this.databaseManagerToolStripMenuItem.Name = "databaseManagerToolStripMenuItem";
            this.databaseManagerToolStripMenuItem.Size = new System.Drawing.Size(194, 25);
            this.databaseManagerToolStripMenuItem.Text = "Database Manager";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.backupToolStripMenuItem.Text = "Backup&Restore";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.monitoringToolStripMenuItem});
            this.userToolStripMenuItem.Image = global::GUI.Properties.Resources.User_48px;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.userToolStripMenuItem.Text = "User";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            this.monitoringToolStripMenuItem.Click += new System.EventHandler(this.monitoringToolStripMenuItem_Click);
            // 
            // dépensesToolStripMenuItem
            // 
            this.dépensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDépensesToolStripMenuItem,
            this.newDépenseToolStripMenuItem});
            this.dépensesToolStripMenuItem.Image = global::GUI.Properties.Resources.Receipt_48px;
            this.dépensesToolStripMenuItem.Name = "dépensesToolStripMenuItem";
            this.dépensesToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.dépensesToolStripMenuItem.Text = "Dépenses";
            // 
            // allDépensesToolStripMenuItem
            // 
            this.allDépensesToolStripMenuItem.Name = "allDépensesToolStripMenuItem";
            this.allDépensesToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.allDépensesToolStripMenuItem.Text = "All Dépenses";
            // 
            // newDépenseToolStripMenuItem
            // 
            this.newDépenseToolStripMenuItem.Name = "newDépenseToolStripMenuItem";
            this.newDépenseToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.newDépenseToolStripMenuItem.Text = "New Dépense";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 700);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dépensesToolStripMenuItem;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem allDépensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDépenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remboursementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvisionnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiquesESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

