namespace GESTION_DES_CONGE
{
    partial class Conge_Maladie
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
            this.ttype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bcalculer = new System.Windows.Forms.Button();
            this.tnombre_jour = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tnomR = new System.Windows.Forms.TextBox();
            this.tdoteR = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tprenomR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tnomRAR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tprenomRAR = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tnomFR = new System.Windows.Forms.TextBox();
            this.tdot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tnomAR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tprenomAR = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tnconge = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttype
            // 
            this.ttype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ttype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ttype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttype.ForeColor = System.Drawing.Color.Black;
            this.ttype.HintForeColor = System.Drawing.Color.Empty;
            this.ttype.HintText = "";
            this.ttype.isPassword = false;
            this.ttype.LineFocusedColor = System.Drawing.Color.Gray;
            this.ttype.LineIdleColor = System.Drawing.Color.Gray;
            this.ttype.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ttype.LineThickness = 2;
            this.ttype.Location = new System.Drawing.Point(107, 223);
            this.ttype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(1039, 28);
            this.ttype.TabIndex = 138;
            this.ttype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bupdate
            // 
            this.bupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bupdate.Location = new System.Drawing.Point(28, 198);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(133, 35);
            this.bupdate.TabIndex = 137;
            this.bupdate.Text = "Modifier";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bdelete
            // 
            this.bdelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bdelete.Location = new System.Drawing.Point(28, 148);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(133, 35);
            this.bdelete.TabIndex = 136;
            this.bdelete.Text = "Supprimer";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // badd
            // 
            this.badd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.badd.Location = new System.Drawing.Point(28, 96);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(133, 35);
            this.badd.TabIndex = 135;
            this.badd.Text = "Ajouter";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1357, 244);
            this.dataGridView1.TabIndex = 134;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.bcalculer);
            this.groupBox1.Controls.Add(this.tnombre_jour);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateD);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateF);
            this.groupBox1.Location = new System.Drawing.Point(105, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 60);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bcalculer
            // 
            this.bcalculer.Location = new System.Drawing.Point(584, 22);
            this.bcalculer.Name = "bcalculer";
            this.bcalculer.Size = new System.Drawing.Size(108, 31);
            this.bcalculer.TabIndex = 114;
            this.bcalculer.Text = "calculer date fin";
            this.bcalculer.UseVisualStyleBackColor = true;
            this.bcalculer.Click += new System.EventHandler(this.bcalculer_Click);
            // 
            // tnombre_jour
            // 
            this.tnombre_jour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnombre_jour.Location = new System.Drawing.Point(478, 22);
            this.tnombre_jour.Multiline = true;
            this.tnombre_jour.Name = "tnombre_jour";
            this.tnombre_jour.Size = new System.Drawing.Size(50, 28);
            this.tnombre_jour.TabIndex = 13;
            this.tnombre_jour.TextChanged += new System.EventHandler(this.tnombre_jour_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 107;
            this.label11.Text = "Date debut :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(371, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 113;
            this.label12.Text = "Nombre de jours :";
            // 
            // dateD
            // 
            this.dateD.CustomFormat = "yyyy-MM-dd";
            this.dateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateD.Location = new System.Drawing.Point(105, 24);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(233, 26);
            this.dateD.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(717, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 110;
            this.label13.Text = "Date fin :";
            // 
            // dateF
            // 
            this.dateF.CustomFormat = "yyyy-MM-dd";
            this.dateF.Enabled = false;
            this.dateF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateF.Location = new System.Drawing.Point(792, 22);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(233, 26);
            this.dateF.TabIndex = 111;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.tnomR);
            this.groupBox3.Controls.Add(this.tdoteR);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tprenomR);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tnomRAR);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tprenomRAR);
            this.groupBox3.Location = new System.Drawing.Point(105, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1041, 114);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information de l\'agent Remplacement";
            // 
            // tnomR
            // 
            this.tnomR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnomR.Location = new System.Drawing.Point(250, 46);
            this.tnomR.Name = "tnomR";
            this.tnomR.Size = new System.Drawing.Size(278, 22);
            this.tnomR.TabIndex = 23;
            this.tnomR.TextChanged += new System.EventHandler(this.tnomR_TextChanged);
            // 
            // tdoteR
            // 
            this.tdoteR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tdoteR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdoteR.FormattingEnabled = true;
            this.tdoteR.Location = new System.Drawing.Point(250, 17);
            this.tdoteR.Name = "tdoteR";
            this.tdoteR.Size = new System.Drawing.Size(278, 24);
            this.tdoteR.TabIndex = 22;
            this.tdoteR.SelectedIndexChanged += new System.EventHandler(this.tdoteR_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "N dote :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Prenom :";
            // 
            // tprenomR
            // 
            this.tprenomR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tprenomR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprenomR.Location = new System.Drawing.Point(250, 74);
            this.tprenomR.Multiline = true;
            this.tprenomR.Name = "tprenomR";
            this.tprenomR.ReadOnly = true;
            this.tprenomR.Size = new System.Drawing.Size(278, 26);
            this.tprenomR.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(845, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "الاسم";
            // 
            // tnomRAR
            // 
            this.tnomRAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tnomRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnomRAR.Location = new System.Drawing.Point(547, 29);
            this.tnomRAR.Multiline = true;
            this.tnomRAR.Name = "tnomRAR";
            this.tnomRAR.ReadOnly = true;
            this.tnomRAR.Size = new System.Drawing.Size(278, 26);
            this.tnomRAR.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(845, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "النسب";
            // 
            // tprenomRAR
            // 
            this.tprenomRAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tprenomRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprenomRAR.Location = new System.Drawing.Point(547, 64);
            this.tprenomRAR.Multiline = true;
            this.tprenomRAR.Name = "tprenomRAR";
            this.tprenomRAR.ReadOnly = true;
            this.tprenomRAR.Size = new System.Drawing.Size(278, 26);
            this.tprenomRAR.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tnomFR);
            this.groupBox2.Controls.Add(this.tdot);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tprenom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tnomAR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tprenomAR);
            this.groupBox2.Location = new System.Drawing.Point(105, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 115);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations de l\'agent";
            // 
            // tnomFR
            // 
            this.tnomFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnomFR.Location = new System.Drawing.Point(250, 48);
            this.tnomFR.Name = "tnomFR";
            this.tnomFR.Size = new System.Drawing.Size(278, 22);
            this.tnomFR.TabIndex = 12;
            this.tnomFR.TextChanged += new System.EventHandler(this.tnomFR_TextChanged);
            // 
            // tdot
            // 
            this.tdot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdot.FormattingEnabled = true;
            this.tdot.Location = new System.Drawing.Point(250, 20);
            this.tdot.Name = "tdot";
            this.tdot.Size = new System.Drawing.Size(278, 24);
            this.tdot.TabIndex = 11;
            this.tdot.SelectedIndexChanged += new System.EventHandler(this.tdot_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "N dote :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenom :";
            // 
            // tprenom
            // 
            this.tprenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprenom.Location = new System.Drawing.Point(250, 76);
            this.tprenom.Multiline = true;
            this.tprenom.Name = "tprenom";
            this.tprenom.ReadOnly = true;
            this.tprenom.Size = new System.Drawing.Size(278, 26);
            this.tprenom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(858, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "الاسم";
            // 
            // tnomAR
            // 
            this.tnomAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tnomAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnomAR.Location = new System.Drawing.Point(561, 29);
            this.tnomAR.Multiline = true;
            this.tnomAR.Name = "tnomAR";
            this.tnomAR.ReadOnly = true;
            this.tnomAR.Size = new System.Drawing.Size(278, 26);
            this.tnomAR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(858, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "النسب";
            // 
            // tprenomAR
            // 
            this.tprenomAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tprenomAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprenomAR.Location = new System.Drawing.Point(561, 60);
            this.tprenomAR.Multiline = true;
            this.tprenomAR.Name = "tprenomAR";
            this.tprenomAR.ReadOnly = true;
            this.tprenomAR.Size = new System.Drawing.Size(278, 26);
            this.tprenomAR.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bupdate);
            this.groupBox4.Controls.Add(this.bdelete);
            this.groupBox4.Controls.Add(this.badd);
            this.groupBox4.Location = new System.Drawing.Point(1152, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 368);
            this.groupBox4.TabIndex = 139;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // tnconge
            // 
            this.tnconge.Location = new System.Drawing.Point(533, 8);
            this.tnconge.Name = "tnconge";
            this.tnconge.Size = new System.Drawing.Size(100, 20);
            this.tnconge.TabIndex = 66;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(465, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "N° Conge :";
            // 
            // Conge_Maladie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 648);
            this.Controls.Add(this.tnconge);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conge_Maladie";
            this.Text = "Conge_Maladie";
            this.Load += new System.EventHandler(this.Conge_Maladie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox ttype;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bcalculer;
        private System.Windows.Forms.TextBox tnombre_jour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tnomR;
        private System.Windows.Forms.ComboBox tdoteR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tprenomR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tnomRAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tprenomRAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tnomFR;
        private System.Windows.Forms.ComboBox tdot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tnomAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tprenomAR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tnconge;
        private System.Windows.Forms.Label label16;
    }
}