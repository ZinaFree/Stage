using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GESTION_DES_CONGE
{
    public partial class conge_expirer : Form
    {
        public conge_expirer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=ABD-ASSAMAD-DES ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void conge_expirer_Load(object sender, EventArgs e)
        {
            conges_expirer();
        }

        private void conges_expirer()
        {
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,id_service,service_AR,duree_date_precedent,duree_date_actuel from Employe where duree_date_precedent<>0", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
