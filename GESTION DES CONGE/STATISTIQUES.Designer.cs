namespace GESTION_DES_CONGE
{
    partial class STATISTIQUES
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g1date = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rmaladie = new System.Windows.Forms.RadioButton();
            this.rexceptionel = new System.Windows.Forms.RadioButton();
            this.ranuel = new System.Windows.Forms.RadioButton();
            this.rtous = new System.Windows.Forms.RadioButton();
            this.bprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.g1date.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1180, 390);
            this.dataGridView1.TabIndex = 7;
            // 
            // g1date
            // 
            this.g1date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.g1date.Controls.Add(this.button1);
            this.g1date.Controls.Add(this.label2);
            this.g1date.Controls.Add(this.label1);
            this.g1date.Controls.Add(this.date2);
            this.g1date.Controls.Add(this.date1);
            this.g1date.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g1date.ForeColor = System.Drawing.Color.White;
            this.g1date.Location = new System.Drawing.Point(176, 100);
            this.g1date.Name = "g1date";
            this.g1date.Size = new System.Drawing.Size(846, 72);
            this.g1date.TabIndex = 6;
            this.g1date.TabStop = false;
            this.g1date.Text = "rechercher par date ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(684, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date debut :";
            // 
            // date2
            // 
            this.date2.CustomFormat = "yyyy-MM-dd";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(469, 29);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 29);
            this.date2.TabIndex = 1;
            // 
            // date1
            // 
            this.date1.CustomFormat = "yyyy-MM-dd";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(159, 29);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 29);
            this.date1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rmaladie);
            this.groupBox1.Controls.Add(this.rexceptionel);
            this.groupBox1.Controls.Add(this.ranuel);
            this.groupBox1.Controls.Add(this.rtous);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(176, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisire le type de conge";
            // 
            // rmaladie
            // 
            this.rmaladie.AutoSize = true;
            this.rmaladie.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmaladie.Location = new System.Drawing.Point(673, 28);
            this.rmaladie.Name = "rmaladie";
            this.rmaladie.Size = new System.Drawing.Size(143, 25);
            this.rmaladie.TabIndex = 3;
            this.rmaladie.TabStop = true;
            this.rmaladie.Text = "Conge maladie";
            this.rmaladie.UseVisualStyleBackColor = true;
            this.rmaladie.CheckedChanged += new System.EventHandler(this.rmaladie_CheckedChanged);
            // 
            // rexceptionel
            // 
            this.rexceptionel.AutoSize = true;
            this.rexceptionel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rexceptionel.Location = new System.Drawing.Point(434, 28);
            this.rexceptionel.Name = "rexceptionel";
            this.rexceptionel.Size = new System.Drawing.Size(183, 25);
            this.rexceptionel.TabIndex = 2;
            this.rexceptionel.TabStop = true;
            this.rexceptionel.Text = "Conge exceptionelle";
            this.rexceptionel.UseVisualStyleBackColor = true;
            this.rexceptionel.CheckedChanged += new System.EventHandler(this.rexceptionel_CheckedChanged);
            // 
            // ranuel
            // 
            this.ranuel.AutoSize = true;
            this.ranuel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranuel.Location = new System.Drawing.Point(253, 28);
            this.ranuel.Name = "ranuel";
            this.ranuel.Size = new System.Drawing.Size(125, 25);
            this.ranuel.TabIndex = 1;
            this.ranuel.TabStop = true;
            this.ranuel.Text = "Conge anuel";
            this.ranuel.UseVisualStyleBackColor = true;
            this.ranuel.CheckedChanged += new System.EventHandler(this.ranuel_CheckedChanged);
            // 
            // rtous
            // 
            this.rtous.AutoSize = true;
            this.rtous.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtous.Location = new System.Drawing.Point(43, 28);
            this.rtous.Name = "rtous";
            this.rtous.Size = new System.Drawing.Size(154, 25);
            this.rtous.TabIndex = 0;
            this.rtous.TabStop = true;
            this.rtous.Text = "Touts les conges";
            this.rtous.UseVisualStyleBackColor = true;
            this.rtous.CheckedChanged += new System.EventHandler(this.rtous_CheckedChanged);
            // 
            // bprint
            // 
            this.bprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bprint.BackColor = System.Drawing.Color.White;
            this.bprint.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bprint.Location = new System.Drawing.Point(1046, 574);
            this.bprint.Name = "bprint";
            this.bprint.Size = new System.Drawing.Size(146, 29);
            this.bprint.TabIndex = 8;
            this.bprint.Text = "Imprimer Tous";
            this.bprint.UseVisualStyleBackColor = false;
            this.bprint.Click += new System.EventHandler(this.bprint_Click);
            // 
            // STATISTIQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1204, 609);
            this.Controls.Add(this.bprint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.g1date);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STATISTIQUES";
            this.Text = "STATISTIQUES";
            this.Load += new System.EventHandler(this.STATISTIQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.g1date.ResumeLayout(false);
            this.g1date.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox g1date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rmaladie;
        private System.Windows.Forms.RadioButton rexceptionel;
        private System.Windows.Forms.RadioButton ranuel;
        private System.Windows.Forms.RadioButton rtous;
        private System.Windows.Forms.Button bprint;
    }
}