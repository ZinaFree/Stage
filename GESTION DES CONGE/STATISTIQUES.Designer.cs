﻿namespace GESTION_DES_CONGE
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 374);
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
            this.g1date.Location = new System.Drawing.Point(166, 100);
            this.g1date.Name = "g1date";
            this.g1date.Size = new System.Drawing.Size(846, 72);
            this.g1date.TabIndex = 6;
            this.g1date.TabStop = false;
            this.g1date.Text = "rechercher par date ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "date fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date debut :";
            // 
            // date2
            // 
            this.date2.CustomFormat = "yyyy-MM-dd";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(463, 29);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 20);
            this.date2.TabIndex = 1;
            // 
            // date1
            // 
            this.date1.CustomFormat = "yyyy-MM-dd";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(174, 29);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 20);
            this.date1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rmaladie);
            this.groupBox1.Controls.Add(this.rexceptionel);
            this.groupBox1.Controls.Add(this.ranuel);
            this.groupBox1.Controls.Add(this.rtous);
            this.groupBox1.Location = new System.Drawing.Point(166, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisire le type de conge";
            // 
            // rmaladie
            // 
            this.rmaladie.AutoSize = true;
            this.rmaladie.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmaladie.Location = new System.Drawing.Point(685, 28);
            this.rmaladie.Name = "rmaladie";
            this.rmaladie.Size = new System.Drawing.Size(119, 22);
            this.rmaladie.TabIndex = 3;
            this.rmaladie.TabStop = true;
            this.rmaladie.Text = "Conge maladie";
            this.rmaladie.UseVisualStyleBackColor = true;
            this.rmaladie.CheckedChanged += new System.EventHandler(this.rmaladie_CheckedChanged);
            // 
            // rexceptionel
            // 
            this.rexceptionel.AutoSize = true;
            this.rexceptionel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rexceptionel.Location = new System.Drawing.Point(480, 28);
            this.rexceptionel.Name = "rexceptionel";
            this.rexceptionel.Size = new System.Drawing.Size(151, 22);
            this.rexceptionel.TabIndex = 2;
            this.rexceptionel.TabStop = true;
            this.rexceptionel.Text = "Conge exceptionelle";
            this.rexceptionel.UseVisualStyleBackColor = true;
            this.rexceptionel.CheckedChanged += new System.EventHandler(this.rexceptionel_CheckedChanged);
            // 
            // ranuel
            // 
            this.ranuel.AutoSize = true;
            this.ranuel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranuel.Location = new System.Drawing.Point(278, 28);
            this.ranuel.Name = "ranuel";
            this.ranuel.Size = new System.Drawing.Size(104, 22);
            this.ranuel.TabIndex = 1;
            this.ranuel.TabStop = true;
            this.ranuel.Text = "Conge anuel";
            this.ranuel.UseVisualStyleBackColor = true;
            this.ranuel.CheckedChanged += new System.EventHandler(this.ranuel_CheckedChanged);
            // 
            // rtous
            // 
            this.rtous.AutoSize = true;
            this.rtous.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtous.Location = new System.Drawing.Point(79, 28);
            this.rtous.Name = "rtous";
            this.rtous.Size = new System.Drawing.Size(130, 22);
            this.rtous.TabIndex = 0;
            this.rtous.TabStop = true;
            this.rtous.Text = "Touts les conges";
            this.rtous.UseVisualStyleBackColor = true;
            this.rtous.CheckedChanged += new System.EventHandler(this.rtous_CheckedChanged);
            // 
            // bprint
            // 
            this.bprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bprint.Location = new System.Drawing.Point(1027, 571);
            this.bprint.Name = "bprint";
            this.bprint.Size = new System.Drawing.Size(146, 23);
            this.bprint.TabIndex = 8;
            this.bprint.Text = "Imprimer Tous";
            this.bprint.UseVisualStyleBackColor = true;
            this.bprint.Click += new System.EventHandler(this.bprint_Click);
            // 
            // STATISTIQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 602);
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