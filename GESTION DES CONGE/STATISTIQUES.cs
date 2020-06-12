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
    public partial class STATISTIQUES : Form
    {
        public STATISTIQUES()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(@"data source=zz\sqlExpress ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void bprint_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from conge", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "conge");
            print_all r1 = new print_all();
            r1.SetDataSource(ds);
            christal_report p = new christal_report(r1);
            p.Show();
            con.Close();

        }

        private void STATISTIQUES_Load(object sender, EventArgs e)
        {
            charger_tous();
            rtous.Checked = true;
        }
        public void charger_tous()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void conge_anuel()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge where id_type_c=1", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void congeexceptionelle()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge where id_type_c=2", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void conge_maladie()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge where id_type_c=3", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void rtous_CheckedChanged(object sender, EventArgs e)
        {
            charger_tous();
        }

        private void ranuel_CheckedChanged(object sender, EventArgs e)
        {
            conge_anuel();
        }

        private void rexceptionel_CheckedChanged(object sender, EventArgs e)
        {
            congeexceptionelle();
        }

        private void rmaladie_CheckedChanged(object sender, EventArgs e)
        {
            conge_maladie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtous.Checked)
            {
                tous_chercher_avec_date();
            }
            else
               if (ranuel.Checked)
            {
                anuelle_chercher_avec_date();
            }
            else
               if (rexceptionel.Checked)
            {
                exceptionelle_chercher_avec_date();
            }
            else
               if (rmaladie.Checked)
            {
                maladie_chercher_avec_date();
            }
        }
        public void tous_chercher_avec_date()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c where c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void anuelle_chercher_avec_date()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c  where c.id_type_c=1 and c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void exceptionelle_chercher_avec_date()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c  where c.id_type_c=2 and c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void maladie_chercher_avec_date()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c  where c.id_type_c=3 and c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
