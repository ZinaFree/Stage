using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using GESTION_DES_CONGE.Properties;

namespace GESTION_DES_CONGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=ABD-ASSAMAD-DES ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void bconexion_Click(object sender, EventArgs e)
        {
            try
            {
                Form_index_ f = new Form_index_();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employe where login='" + tlogin.Text + "' and mot_de_pass='" + tpass.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if(dr[12].ToString()=="Admin")
                    {
                        f.Show();
                    }
                    else
                    {
                        f.Show();
                        //Form_index_.getFormindex.bupdate_employes.Visible = false;
                        Form_index_.getFormindex.bservice.Visible = false;
                        Form_index_.getFormindex.bcongé.Visible = false;
                        Form_index_.getFormindex.pnotification.Visible = false;
                      
                    }

                   
                }

                else
                {
                    MessageBox.Show("Login ou mot de pass est incorrect !");
                }
                
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //Mylogin = tlogin.Text;
        }

        private void banuller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
