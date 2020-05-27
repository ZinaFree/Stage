namespace GESTION_DES_CONGE
{
    partial class Services_
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.devisionAR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.devision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idDevision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Data_division = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tdevisionAR = new System.Windows.Forms.TextBox();
            this.tdevisionFR = new System.Windows.Forms.TextBox();
            this.tid_devision = new System.Windows.Forms.ComboBox();
            this.ldevision = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tservice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tidservice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tserviceAR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Data_Service = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Data_all_contant = new System.Windows.Forms.DataGridView();
            this.Data_all = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_division)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Service)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_all_contant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_all)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 615);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.devisionAR);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.devision);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.idDevision);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Data_division);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Division des services";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(207, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 45);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // devisionAR
            // 
            this.devisionAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.devisionAR.Location = new System.Drawing.Point(491, 91);
            this.devisionAR.Name = "devisionAR";
            this.devisionAR.Size = new System.Drawing.Size(233, 21);
            this.devisionAR.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "قسم";
            // 
            // devision
            // 
            this.devision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.devision.Location = new System.Drawing.Point(245, 91);
            this.devision.Name = "devision";
            this.devision.Size = new System.Drawing.Size(233, 21);
            this.devision.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Devision :";
            // 
            // idDevision
            // 
            this.idDevision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idDevision.Location = new System.Drawing.Point(370, 48);
            this.idDevision.Name = "idDevision";
            this.idDevision.Size = new System.Drawing.Size(233, 21);
            this.idDevision.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID devision";
            // 
            // Data_division
            // 
            this.Data_division.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_division.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_division.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_division.Location = new System.Drawing.Point(8, 212);
            this.Data_division.Name = "Data_division";
            this.Data_division.Size = new System.Drawing.Size(1016, 369);
            this.Data_division.TabIndex = 24;
            this.Data_division.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.Data_Service);
            this.tabPage2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(162, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 22);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "Sous un Devision";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.tdevisionAR);
            this.groupBox3.Controls.Add(this.tdevisionFR);
            this.groupBox3.Controls.Add(this.tid_devision);
            this.groupBox3.Controls.Add(this.ldevision);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(85, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(911, 74);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devision des service";
            // 
            // tdevisionAR
            // 
            this.tdevisionAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdevisionAR.Location = new System.Drawing.Point(544, 30);
            this.tdevisionAR.Multiline = true;
            this.tdevisionAR.Name = "tdevisionAR";
            this.tdevisionAR.ReadOnly = true;
            this.tdevisionAR.Size = new System.Drawing.Size(247, 24);
            this.tdevisionAR.TabIndex = 18;
            // 
            // tdevisionFR
            // 
            this.tdevisionFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdevisionFR.Location = new System.Drawing.Point(282, 30);
            this.tdevisionFR.Multiline = true;
            this.tdevisionFR.Name = "tdevisionFR";
            this.tdevisionFR.ReadOnly = true;
            this.tdevisionFR.Size = new System.Drawing.Size(256, 24);
            this.tdevisionFR.TabIndex = 7;
            // 
            // tid_devision
            // 
            this.tid_devision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tid_devision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tid_devision.FormattingEnabled = true;
            this.tid_devision.Location = new System.Drawing.Point(111, 28);
            this.tid_devision.Name = "tid_devision";
            this.tid_devision.Size = new System.Drawing.Size(60, 26);
            this.tid_devision.TabIndex = 17;
            this.tid_devision.SelectedIndexChanged += new System.EventHandler(this.tid_devision_SelectedIndexChanged);
            // 
            // ldevision
            // 
            this.ldevision.AutoSize = true;
            this.ldevision.Location = new System.Drawing.Point(209, 33);
            this.ldevision.Name = "ldevision";
            this.ldevision.Size = new System.Drawing.Size(70, 18);
            this.ldevision.TabIndex = 7;
            this.ldevision.Text = "devision :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "id_devision";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tservice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tidservice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tserviceAR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(85, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 84);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone des service";
            // 
            // tservice
            // 
            this.tservice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tservice.Location = new System.Drawing.Point(282, 37);
            this.tservice.Multiline = true;
            this.tservice.Name = "tservice";
            this.tservice.Size = new System.Drawing.Size(256, 24);
            this.tservice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Id service";
            // 
            // tidservice
            // 
            this.tidservice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tidservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidservice.Location = new System.Drawing.Point(111, 37);
            this.tidservice.Multiline = true;
            this.tidservice.Name = "tidservice";
            this.tidservice.Size = new System.Drawing.Size(60, 24);
            this.tidservice.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Service :";
            // 
            // tserviceAR
            // 
            this.tserviceAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tserviceAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tserviceAR.Location = new System.Drawing.Point(544, 37);
            this.tserviceAR.Multiline = true;
            this.tserviceAR.Name = "tserviceAR";
            this.tserviceAR.Size = new System.Drawing.Size(247, 24);
            this.tserviceAR.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "خدمة";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(232, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 56);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(442, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nouveau";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "Supprimer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 25);
            this.button6.TabIndex = 1;
            this.button6.Text = "Modifier";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(65, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 25);
            this.button7.TabIndex = 0;
            this.button7.Text = "Ajouter";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(190, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 22);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Sous un Devision";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Data_Service
            // 
            this.Data_Service.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_Service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Service.Location = new System.Drawing.Point(8, 280);
            this.Data_Service.Name = "Data_Service";
            this.Data_Service.Size = new System.Drawing.Size(1016, 290);
            this.Data_Service.TabIndex = 29;
            this.Data_Service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.Data_all_contant);
            this.tabPage3.Controls.Add(this.Data_all);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1032, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Voir tous ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(267, 214);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(290, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Afficher les services qui sont pas accorder a un division ";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Data_all_contant
            // 
            this.Data_all_contant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_all_contant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_all_contant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_all_contant.Location = new System.Drawing.Point(8, 244);
            this.Data_all_contant.Name = "Data_all_contant";
            this.Data_all_contant.Size = new System.Drawing.Size(1016, 318);
            this.Data_all_contant.TabIndex = 13;
            // 
            // Data_all
            // 
            this.Data_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_all.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_all.Location = new System.Drawing.Point(8, 18);
            this.Data_all.Name = "Data_all";
            this.Data_all.Size = new System.Drawing.Size(1016, 189);
            this.Data_all.TabIndex = 12;
            this.Data_all.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_all_CellContentClick);
            // 
            // Services_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 615);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1056, 654);
            this.MinimumSize = new System.Drawing.Size(1056, 654);
            this.Name = "Services_";
            this.Text = "Services_";
            this.Load += new System.EventHandler(this.Services__Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_division)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Service)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_all_contant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_all)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox devisionAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox devision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idDevision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Data_division;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tdevisionAR;
        private System.Windows.Forms.TextBox tdevisionFR;
        private System.Windows.Forms.ComboBox tid_devision;
        private System.Windows.Forms.Label ldevision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tservice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tidservice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tserviceAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView Data_Service;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView Data_all_contant;
        private System.Windows.Forms.DataGridView Data_all;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}