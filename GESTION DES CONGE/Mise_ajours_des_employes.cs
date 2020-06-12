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
    public partial class Mise_ajours_des_employes : Form
    {
        public Mise_ajours_des_employes()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=zz\sqlExpress ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void Mise_ajours_des_employes_Load(object sender, EventArgs e)
        {
            chargerGrid();
            remplire_combo();
            charger_service();

            bupdate.Enabled = false;
            bdelete.Enabled = false;
            bsearch.Enabled = false;
            bnew.Enabled = false;
            tdure.Text = "0";
        }
        public void chargerGrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,id_service,service_AR,duree_date_precedent,duree_date_actuel from EMPLOYE ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //methode verifier
        }
        public void verifier()
        {
            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand("select N_dote from employe where N_dote='" + tid.Text + "'", con);
                //SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //con.Close();
                //if (dt.Rows.Count > 0)
                //    MessageBox.Show("L'employé excist deja", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //{
                //    ajouter();
                //    chargerGrid();
                //}
                SqlDataAdapter da = new SqlDataAdapter("select N_dote from employe where N_dote='" + tid.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "employe");
                if (ds.Tables["employe"].Rows.Count > 0)
                {
                    MessageBox.Show("L'employé exsiste deja", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ajouter();
                    chargerGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ajouter()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into employe(N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,id_service,service_AR,duree_date_precedent,duree_date_actuel) values('" + tid.Text + "', '" + tnom.Text + "', '" + tprenom.Text + "', '" + tnomAR.Text + "', '" + tprenomAR.Text + "', '" + tgrade.Text + "', '" + tgradeAR.Text + "','" + tidservice.Text + "','"+tserviceAR.Text+"',0,'" + tdure.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tid.Text != "" && tnom.Text != "" && tprenom.Text != "" && tgrade.Text != "" && tservice.Text != "" && tnomAR.Text != "" && tprenomAR.Text != "" && tgradeAR.Text != "" && tdure.Text != "" && tservice.Text != "" && tserviceAR.Text != "" && tidservice.Text != "")
                {
                    verifier();
                }
                else
                {
                    MessageBox.Show("Remplire tous les shamps SVP !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bupdate.Enabled = true;
            bdelete.Enabled = true;
            bsearch.Enabled = true;
            bnew.Enabled = true;

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    grid.CurrentRow.Selected = true;
                    tid.Text = grid.Rows[e.RowIndex].Cells["N_dote"].FormattedValue.ToString();
                    tnom.Text = grid.Rows[e.RowIndex].Cells["Nom_FR"].FormattedValue.ToString();
                    tprenom.Text = grid.Rows[e.RowIndex].Cells["Prenom_FR"].FormattedValue.ToString();
                    tgrade.Text = grid.Rows[e.RowIndex].Cells["Grade_FR"].FormattedValue.ToString();
                    //tservice.Text = grid.Rows[e.RowIndex].Cells["Service_FR"].FormattedValue.ToString();
                    tnomAR.Text = grid.Rows[e.RowIndex].Cells["Nom_AR"].FormattedValue.ToString();
                    tprenomAR.Text = grid.Rows[e.RowIndex].Cells["Prenom_AR"].FormattedValue.ToString();
                    tgradeAR.Text = grid.Rows[e.RowIndex].Cells["Grade_AR"].FormattedValue.ToString();
                    tdure.Text = grid.Rows[e.RowIndex].Cells["duree_date_actuel"].FormattedValue.ToString();
                    tidservice.Text = grid.Rows[e.RowIndex].Cells["id_service"].FormattedValue.ToString();
                    //tservice.Text = grid.Rows[e.RowIndex].Cells["service_FR"].FormattedValue.ToString();
                    //tserviceAR.Text = grid.Rows[e.RowIndex].Cells["service_AR"].FormattedValue.ToString();
                }
                bupdate.Enabled = true;
                bdelete.Enabled = true;
                bsearch.Enabled = true;
                bnew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void verifier_entier(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tid_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifier_entier(e);
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update employe set Nom_FR  ='" + tnom.Text + "',Prenom_FR ='" + tprenom.Text + "',Grade_FR ='" + tgrade.Text + "', Nom_AR ='" + tnomAR.Text + "',Prenom_AR ='" + tprenomAR.Text + "',Grade_AR ='" + tgradeAR.Text + "',id_service='" + tidservice.Text + "',Service_AR='"+tserviceAR.Text+ "',duree_date_actuel='" + tdure.Text + "'where N_dote='" + tid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            chargerGrid();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer l'employé ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete employe where N_dote='" + tid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                chargerGrid();
            }
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employe where N_dote='" + tid.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tnom.Text = dr[1].ToString();
                tprenom.Text = dr[2].ToString();
                tgrade.Text = dr[5].ToString();
                tnomAR.Text = dr[3].ToString();
                tprenomAR.Text = dr[4].ToString();
                tgradeAR.Text = dr[6].ToString();
                tdure.Text = dr[9].ToString();
                tidservice.Text = dr[13].ToString();
                //tservice.Text = dr[15].ToString();
                //tserviceAR.Text = dr[14].ToString();            
            }

            else
                MessageBox.Show("Enixiste !");
            con.Close();
        }

        private void tidservice_TextChanged(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select libelle_S_FR,libelle_S_AR from service where id_service='" + tidservice.Text + "'", con);
            //con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    tservice.Text = dr[0].ToString();
            //    tserviceAR.Text = dr[1].ToString();

            //}
            //else
            //    MessageBox.Show("Enixcist !", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //con.Close();

        }

        public void Autocomplete()
        {

            SqlCommand cmd = new SqlCommand("select * from service", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                auto.Add(dr.GetString(1));
            }
            tidservice.AutoCompleteMode = AutoCompleteMode.Suggest;
            tidservice.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tidservice.AutoCompleteCustomSource = auto;
            con.Close();
        }
        // remplire combobox 
        public void remplire_combo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for(int i=0;i<ds.Tables["service"].Rows.Count;i++)
            {
                tidservice.Items.Add(ds.Tables["service"].Rows[i][0]);
            }
        }
        private void tidservice_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                if(tidservice.SelectedItem.Equals(ds.Tables["service"].Rows[i][0]))
                {
                    tservice.Text = ds.Tables["service"].Rows[i][1].ToString();
                    tserviceAR.Text = ds.Tables["service"].Rows[i][2].ToString();
                }
            }
        }

        //auto complete search with name
        public void charger_service()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                tservice.Items.Add(ds.Tables["service"].Rows[i][1]);
            }
        }

        private void tservice_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                if (tservice.SelectedItem.Equals(ds.Tables["service"].Rows[i][1]))
                {
                    tidservice.Text = ds.Tables["service"].Rows[i][0].ToString();
                
                }
            }
        }

        private void bnew_Click(object sender, EventArgs e)
        {
            clear();
            bupdate.Enabled = false;
            bdelete.Enabled = false;
            bsearch.Enabled = false;
            bnew.Enabled = false;
        }
        public void clear()
        {
            tdure.Clear();
            tid.Clear();
            tnom.Clear();
            tnomAR.Clear();
            tprenom.Clear();
            tprenomAR.Clear();
            tidservice.Text = "";
            tservice.Text = "";
            tserviceAR.Clear();
            tgrade.Clear();
            tgradeAR.Clear();
        }

        private void tdure_TextChanged(object sender, EventArgs e)
        {
            //if (int.Parse(tdure.Text) > 22)
            //{
            //    MessageBox.Show("Vous avez deppasser le nombre de jours de conge [22]");
            //    tdure.Text = "0";
            //}
            //if(tdure.Text=="")
            //{
            //    tdure.Text = "0";
            //}
        }

        private void tdure_Click(object sender, EventArgs e)
        {
            if(tdure.Text=="0")
            {
                tdure.Text = "";
            }      
        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
