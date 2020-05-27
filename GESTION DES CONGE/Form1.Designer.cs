namespace GESTION_DES_CONGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlogin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.banuller = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bconexion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mot de pass :";
            // 
            // tlogin
            // 
            this.tlogin.AutoSize = true;
            this.tlogin.BorderColorFocused = System.Drawing.Color.DarkTurquoise;
            this.tlogin.BorderColorIdle = System.Drawing.Color.DeepSkyBlue;
            this.tlogin.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tlogin.BorderThickness = 2;
            this.tlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tlogin.isPassword = false;
            this.tlogin.Location = new System.Drawing.Point(178, 88);
            this.tlogin.Margin = new System.Windows.Forms.Padding(4);
            this.tlogin.Name = "tlogin";
            this.tlogin.Size = new System.Drawing.Size(370, 44);
            this.tlogin.TabIndex = 14;
            this.tlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tpass
            // 
            this.tpass.AutoSize = true;
            this.tpass.BorderColorFocused = System.Drawing.Color.DarkTurquoise;
            this.tpass.BorderColorIdle = System.Drawing.Color.DeepSkyBlue;
            this.tpass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tpass.BorderThickness = 2;
            this.tpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpass.isPassword = false;
            this.tpass.Location = new System.Drawing.Point(178, 140);
            this.tpass.Margin = new System.Windows.Forms.Padding(4);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(370, 44);
            this.tpass.TabIndex = 15;
            this.tpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // banuller
            // 
            this.banuller.ActiveBorderThickness = 1;
            this.banuller.ActiveCornerRadius = 20;
            this.banuller.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.banuller.ActiveForecolor = System.Drawing.Color.White;
            this.banuller.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.banuller.BackColor = System.Drawing.SystemColors.Control;
            this.banuller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("banuller.BackgroundImage")));
            this.banuller.ButtonText = "Annuller";
            this.banuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banuller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banuller.ForeColor = System.Drawing.Color.Gray;
            this.banuller.IdleBorderThickness = 1;
            this.banuller.IdleCornerRadius = 20;
            this.banuller.IdleFillColor = System.Drawing.Color.White;
            this.banuller.IdleForecolor = System.Drawing.Color.DimGray;
            this.banuller.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.banuller.Location = new System.Drawing.Point(452, 193);
            this.banuller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.banuller.Name = "banuller";
            this.banuller.Size = new System.Drawing.Size(96, 43);
            this.banuller.TabIndex = 17;
            this.banuller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.banuller.Click += new System.EventHandler(this.banuller_Click);
            // 
            // bconexion
            // 
            this.bconexion.ActiveBorderThickness = 1;
            this.bconexion.ActiveCornerRadius = 20;
            this.bconexion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bconexion.ActiveForecolor = System.Drawing.Color.White;
            this.bconexion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bconexion.BackColor = System.Drawing.SystemColors.Control;
            this.bconexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconexion.BackgroundImage")));
            this.bconexion.ButtonText = "Connexion";
            this.bconexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bconexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bconexion.ForeColor = System.Drawing.Color.DimGray;
            this.bconexion.IdleBorderThickness = 1;
            this.bconexion.IdleCornerRadius = 20;
            this.bconexion.IdleFillColor = System.Drawing.Color.White;
            this.bconexion.IdleForecolor = System.Drawing.Color.DimGray;
            this.bconexion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bconexion.Location = new System.Drawing.Point(345, 193);
            this.bconexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bconexion.Name = "bconexion";
            this.bconexion.Size = new System.Drawing.Size(96, 43);
            this.bconexion.TabIndex = 16;
            this.bconexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bconexion.Click += new System.EventHandler(this.bconexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::GESTION_DES_CONGE.Properties.Resources.User_Interface_Delete_Sign_icon;
            this.pictureBox1.Location = new System.Drawing.Point(554, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 262);
            this.Controls.Add(this.banuller);
            this.Controls.Add(this.bconexion);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tlogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox tpass;
        private Bunifu.Framework.UI.BunifuThinButton2 bconexion;
        private Bunifu.Framework.UI.BunifuThinButton2 banuller;
    }
}

