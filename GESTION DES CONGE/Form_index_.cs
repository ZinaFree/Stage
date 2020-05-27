using GESTION_DES_CONGE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace GESTION_DES_CONGE
{
    public partial class Form_index_ : Form
    {
        private static Form_index_ frm_indx;
        static void frm_formClosed(object sender,FormClosedEventArgs e)
        {
            frm_indx = null;
        }
        public static Form_index_ getFormindex
        {
            get
            {
                if(frm_indx==null)
                {
                    frm_indx = new Form_index_();
                    frm_indx.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm_indx;
            }
        }
        public Form_index_()
        {
            InitializeComponent();
            //if(frm_indx==null)
            //{
            //    frm_indx = this;
            //}
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new Mise_ajours_des_employes());
        }
        private void Form_in_Panel(object FormP)
        {
            if (this.Pcontainer.Controls.Count > 0)
                this.Pcontainer.Controls.RemoveAt(0);
            Form fh = FormP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pcontainer.Controls.Add(fh);
            this.Pcontainer.Tag = fh;
            fh.Show();
        }

        private void Form_index__Load(object sender, EventArgs e)
        {
            Form_in_Panel(new STATISTIQUES());
            notification();
            Ptype_congé.Visible = false;
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Services_ s = new Services_();
            s.Show();
        }

        private void bcongé_Click(object sender, EventArgs e)
        {
            if (Ptype_congé.Visible == false)
            {
                Ptype_congé.Visible = true;

            }
            else
            {
                Ptype_congé.Visible = false;
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new CONGE_ANUEL());
            if (Ptype_congé.Visible == true)
            {
                Ptype_congé.Visible = false;
            }
            else
            {
                Ptype_congé.Visible = true;
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new Conge_excepionelle());
            if (Ptype_congé.Visible == true)
            {
                Ptype_congé.Visible = false;
            }
            else
            {
                Ptype_congé.Visible = true;
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new Conge_Maladie());
            if (Ptype_congé.Visible == true)
            {
                Ptype_congé.Visible = false;
            }
            else
            {
                Ptype_congé.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new STATISTIQUES());

        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.Show();
        }

      

        private void psetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bupdate_employes_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Form_in_Panel(new Mise_ajours_des_employes());
        }

        public void notification()
        {
            string dt = DateTime.Now.ToShortDateString();
            if(dt == "1/12")
            {
                pnotification.Image = Properties.Resources.notify;
            }
        }

        private void pnotification_Click(object sender, EventArgs e)
        {
            conge_expirer c = new conge_expirer();
            c.Show();
        }

        private void pnotification_MouseHover(object sender, EventArgs e)
        {
            pnotification.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pnotification_MouseLeave(object sender, EventArgs e)
        {
            pnotification.BorderStyle = BorderStyle.None;
        }

        private void psetting_MouseHover(object sender, EventArgs e)
        {
            psetting.BorderStyle = BorderStyle.FixedSingle;
        }

        private void psetting_MouseLeave(object sender, EventArgs e)
        {
            psetting.BorderStyle = BorderStyle.None;
        }
    }
}
