namespace GUI.Forms
{
    partial class FrmMaison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaison));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnParc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone3 = new System.Windows.Forms.MaskedTextBox();
            this.phone2 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numImpotTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.idNatTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rccmTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boiteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siteTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.siegeTxt = new System.Windows.Forms.TextBox();
            this.raisonTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgMaison = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRaison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSiege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBoite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRccm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdNat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumImpot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaison)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(838, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(790, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 41);
            this.button8.TabIndex = 161;
            this.button8.Text = "X";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 162;
            this.label1.Text = "Informations sur la maison";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.logo);
            this.groupBox4.Controls.Add(this.btnParc);
            this.groupBox4.Location = new System.Drawing.Point(12, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 362);
            this.groupBox4.TabIndex = 163;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(6, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Logo";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(7, 26);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(230, 291);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 36;
            this.logo.TabStop = false;
            // 
            // btnParc
            // 
            this.btnParc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParc.BackColor = System.Drawing.SystemColors.Control;
            this.btnParc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParc.ForeColor = System.Drawing.Color.Black;
            this.btnParc.Image = ((System.Drawing.Image)(resources.GetObject("btnParc.Image")));
            this.btnParc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParc.Location = new System.Drawing.Point(63, 323);
            this.btnParc.Name = "btnParc";
            this.btnParc.Size = new System.Drawing.Size(107, 35);
            this.btnParc.TabIndex = 84;
            this.btnParc.Text = "Parcourrir";
            this.btnParc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParc.UseVisualStyleBackColor = false;
            this.btnParc.Click += new System.EventHandler(this.btnParc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phone3);
            this.groupBox1.Controls.Add(this.phone2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numImpotTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.idNatTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rccmTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.boiteTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.siteTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mailTxt);
            this.groupBox1.Controls.Add(this.siegeTxt);
            this.groupBox1.Controls.Add(this.raisonTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(261, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 363);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            // 
            // phone3
            // 
            this.phone3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phone3.Location = new System.Drawing.Point(406, 143);
            this.phone3.Mask = "+256000000000";
            this.phone3.Name = "phone3";
            this.phone3.Size = new System.Drawing.Size(129, 27);
            this.phone3.TabIndex = 88;
            // 
            // phone2
            // 
            this.phone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phone2.Location = new System.Drawing.Point(268, 143);
            this.phone2.Mask = "+243000000000";
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(122, 27);
            this.phone2.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(6, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 21);
            this.label12.TabIndex = 86;
            this.label12.Text = "Details";
            // 
            // phoneTxt
            // 
            this.phoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phoneTxt.Location = new System.Drawing.Point(123, 143);
            this.phoneTxt.Mask = "+243000000000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(122, 27);
            this.phoneTxt.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(14, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Téléphones :";
            // 
            // numImpotTxt
            // 
            this.numImpotTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numImpotTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.numImpotTxt.Location = new System.Drawing.Point(123, 328);
            this.numImpotTxt.Name = "numImpotTxt";
            this.numImpotTxt.Size = new System.Drawing.Size(412, 27);
            this.numImpotTxt.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(6, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Num. Impot :";
            // 
            // idNatTxt
            // 
            this.idNatTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNatTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idNatTxt.Location = new System.Drawing.Point(123, 295);
            this.idNatTxt.Name = "idNatTxt";
            this.idNatTxt.Size = new System.Drawing.Size(412, 27);
            this.idNatTxt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(52, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "idNat :";
            // 
            // rccmTxt
            // 
            this.rccmTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rccmTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rccmTxt.Location = new System.Drawing.Point(123, 265);
            this.rccmTxt.Name = "rccmTxt";
            this.rccmTxt.Size = new System.Drawing.Size(412, 27);
            this.rccmTxt.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(45, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "RCCM :";
            // 
            // boiteTxt
            // 
            this.boiteTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boiteTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.boiteTxt.Location = new System.Drawing.Point(123, 235);
            this.boiteTxt.Name = "boiteTxt";
            this.boiteTxt.Size = new System.Drawing.Size(412, 27);
            this.boiteTxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(23, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "B. Postale :";
            // 
            // siteTxt
            // 
            this.siteTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.siteTxt.Location = new System.Drawing.Point(123, 205);
            this.siteTxt.Name = "siteTxt";
            this.siteTxt.Size = new System.Drawing.Size(412, 27);
            this.siteTxt.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(28, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Site Web :";
            // 
            // mailTxt
            // 
            this.mailTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.mailTxt.Location = new System.Drawing.Point(123, 175);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(412, 27);
            this.mailTxt.TabIndex = 24;
            // 
            // siegeTxt
            // 
            this.siegeTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siegeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.siegeTxt.Location = new System.Drawing.Point(123, 68);
            this.siegeTxt.Multiline = true;
            this.siegeTxt.Name = "siegeTxt";
            this.siegeTxt.Size = new System.Drawing.Size(412, 69);
            this.siegeTxt.TabIndex = 23;
            // 
            // raisonTxt
            // 
            this.raisonTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raisonTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.raisonTxt.Location = new System.Drawing.Point(123, 37);
            this.raisonTxt.Name = "raisonTxt";
            this.raisonTxt.Size = new System.Drawing.Size(412, 27);
            this.raisonTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(2, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Raison social :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(64, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(10, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Siège social :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(288, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 44);
            this.btnSave.TabIndex = 165;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgMaison
            // 
            this.dgMaison.AllowUserToAddRows = false;
            this.dgMaison.AllowUserToDeleteRows = false;
            this.dgMaison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMaison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMaison.BackgroundColor = System.Drawing.Color.White;
            this.dgMaison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMaison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColRaison,
            this.ColSiege,
            this.ColPhone,
            this.ColPhone2,
            this.ColPhone3,
            this.ColEmail,
            this.ColPhoto,
            this.ColSite,
            this.ColBoite,
            this.ColRccm,
            this.ColIdNat,
            this.ColNumImpot});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMaison.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMaison.Location = new System.Drawing.Point(12, 484);
            this.dgMaison.Name = "dgMaison";
            this.dgMaison.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaison.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMaison.RowHeadersVisible = false;
            this.dgMaison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMaison.Size = new System.Drawing.Size(810, 90);
            this.dgMaison.TabIndex = 166;
            this.dgMaison.SelectionChanged += new System.EventHandler(this.dgMaison_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "N°";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 53;
            // 
            // ColRaison
            // 
            this.ColRaison.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRaison.DataPropertyName = "Nom";
            this.ColRaison.HeaderText = "Raison Social";
            this.ColRaison.Name = "ColRaison";
            this.ColRaison.ReadOnly = true;
            this.ColRaison.Width = 134;
            // 
            // ColSiege
            // 
            this.ColSiege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSiege.DataPropertyName = "Adresse";
            this.ColSiege.HeaderText = "Siège Social";
            this.ColSiege.Name = "ColSiege";
            this.ColSiege.ReadOnly = true;
            this.ColSiege.Width = 126;
            // 
            // ColPhone
            // 
            this.ColPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone.DataPropertyName = "Telephone1";
            this.ColPhone.HeaderText = "Contact1";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            this.ColPhone.Width = 112;
            // 
            // ColPhone2
            // 
            this.ColPhone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone2.DataPropertyName = "Telephone2";
            this.ColPhone2.HeaderText = "Contact2";
            this.ColPhone2.Name = "ColPhone2";
            this.ColPhone2.ReadOnly = true;
            this.ColPhone2.Width = 112;
            // 
            // ColPhone3
            // 
            this.ColPhone3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone3.DataPropertyName = "Telephone3";
            this.ColPhone3.HeaderText = "Contact3";
            this.ColPhone3.Name = "ColPhone3";
            this.ColPhone3.ReadOnly = true;
            this.ColPhone3.Width = 112;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEmail.DataPropertyName = "Mail";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 76;
            // 
            // ColPhoto
            // 
            this.ColPhoto.DataPropertyName = "Logo";
            this.ColPhoto.HeaderText = "Logo";
            this.ColPhoto.Name = "ColPhoto";
            this.ColPhoto.ReadOnly = true;
            this.ColPhoto.Visible = false;
            // 
            // ColSite
            // 
            this.ColSite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSite.DataPropertyName = "Siteweb";
            this.ColSite.HeaderText = "Site Web";
            this.ColSite.Name = "ColSite";
            this.ColSite.ReadOnly = true;
            this.ColSite.Width = 103;
            // 
            // ColBoite
            // 
            this.ColBoite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBoite.DataPropertyName = "BoitePostal";
            this.ColBoite.HeaderText = "Boite Postal";
            this.ColBoite.Name = "ColBoite";
            this.ColBoite.ReadOnly = true;
            this.ColBoite.Width = 124;
            // 
            // ColRccm
            // 
            this.ColRccm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRccm.DataPropertyName = "Rccm";
            this.ColRccm.HeaderText = "RCCM";
            this.ColRccm.Name = "ColRccm";
            this.ColRccm.ReadOnly = true;
            this.ColRccm.Width = 86;
            // 
            // ColIdNat
            // 
            this.ColIdNat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColIdNat.DataPropertyName = "IdNat";
            this.ColIdNat.HeaderText = "ID National";
            this.ColIdNat.Name = "ColIdNat";
            this.ColIdNat.ReadOnly = true;
            this.ColIdNat.Width = 123;
            // 
            // ColNumImpot
            // 
            this.ColNumImpot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNumImpot.DataPropertyName = "NumImpot";
            this.ColNumImpot.HeaderText = "Num Impot";
            this.ColNumImpot.Name = "ColNumImpot";
            this.ColNumImpot.ReadOnly = true;
            this.ColNumImpot.Width = 124;
            // 
            // FrmMaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 619);
            this.Controls.Add(this.dgMaison);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMaison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMaison";
            this.Load += new System.EventHandler(this.FrmMaison_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.Button btnParc;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.MaskedTextBox phone3;
        public System.Windows.Forms.MaskedTextBox phone2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox numImpotTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idNatTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rccmTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boiteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox siteTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox siegeTxt;
        private System.Windows.Forms.TextBox raisonTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgMaison;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRaison;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSiege;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRccm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdNat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumImpot;
    }
}