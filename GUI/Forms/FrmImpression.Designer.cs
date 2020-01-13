namespace GUI.Forms
{
    partial class FrmImpression
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.aticleCombo = new System.Windows.Forms.ComboBox();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFiche = new System.Windows.Forms.RadioButton();
            this.rbtnLivre = new System.Windows.Forms.RadioButton();
            this.rbtnBilan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 77);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1188, 571);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 133;
            this.label5.Text = "Article";
            // 
            // aticleCombo
            // 
            this.aticleCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.aticleCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.aticleCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aticleCombo.FormattingEnabled = true;
            this.aticleCombo.Location = new System.Drawing.Point(74, 12);
            this.aticleCombo.Name = "aticleCombo";
            this.aticleCombo.Size = new System.Drawing.Size(276, 29);
            this.aticleCombo.TabIndex = 132;
            this.aticleCombo.SelectedIndexChanged += new System.EventHandler(this.aticleCombo_SelectedIndexChanged);
            // 
            // monthCombo
            // 
            this.monthCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.monthCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.monthCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCombo.FormattingEnabled = true;
            this.monthCombo.Location = new System.Drawing.Point(424, 12);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.Size = new System.Drawing.Size(221, 29);
            this.monthCombo.TabIndex = 134;
            this.monthCombo.SelectedIndexChanged += new System.EventHandler(this.monthCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 135;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 137;
            this.label2.Text = "Year";
            // 
            // yearCombo
            // 
            this.yearCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.yearCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.Location = new System.Drawing.Point(716, 12);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(191, 29);
            this.yearCombo.TabIndex = 136;
            this.yearCombo.SelectedIndexChanged += new System.EventHandler(this.yearCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBilan);
            this.groupBox1.Controls.Add(this.rbtnFiche);
            this.groupBox1.Controls.Add(this.rbtnLivre);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(926, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 69);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            // 
            // rbtnFiche
            // 
            this.rbtnFiche.AutoSize = true;
            this.rbtnFiche.Location = new System.Drawing.Point(16, 38);
            this.rbtnFiche.Name = "rbtnFiche";
            this.rbtnFiche.Size = new System.Drawing.Size(141, 25);
            this.rbtnFiche.TabIndex = 1;
            this.rbtnFiche.TabStop = true;
            this.rbtnFiche.Text = "Fiche de Stock";
            this.rbtnFiche.UseVisualStyleBackColor = true;
            this.rbtnFiche.CheckedChanged += new System.EventHandler(this.rbtnFiche_CheckedChanged);
            // 
            // rbtnLivre
            // 
            this.rbtnLivre.AutoSize = true;
            this.rbtnLivre.Location = new System.Drawing.Point(16, 15);
            this.rbtnLivre.Name = "rbtnLivre";
            this.rbtnLivre.Size = new System.Drawing.Size(141, 25);
            this.rbtnLivre.TabIndex = 0;
            this.rbtnLivre.TabStop = true;
            this.rbtnLivre.Text = "Livre de Caisse";
            this.rbtnLivre.UseVisualStyleBackColor = true;
            this.rbtnLivre.CheckedChanged += new System.EventHandler(this.rbtnLivre_CheckedChanged);
            // 
            // rbtnBilan
            // 
            this.rbtnBilan.AutoSize = true;
            this.rbtnBilan.Location = new System.Drawing.Point(163, 15);
            this.rbtnBilan.Name = "rbtnBilan";
            this.rbtnBilan.Size = new System.Drawing.Size(64, 25);
            this.rbtnBilan.TabIndex = 2;
            this.rbtnBilan.TabStop = true;
            this.rbtnBilan.Text = "Bilan";
            this.rbtnBilan.UseVisualStyleBackColor = true;
            this.rbtnBilan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FrmImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aticleCombo);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmImpression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImpression";
            this.Load += new System.EventHandler(this.FrmImpression_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox aticleCombo;
        private System.Windows.Forms.ComboBox monthCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFiche;
        private System.Windows.Forms.RadioButton rbtnLivre;
        private System.Windows.Forms.RadioButton rbtnBilan;
    }
}