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
    public partial class Conge_Maladie : Form
    {
        public Conge_Maladie()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(@"data source=zz\sqlExpress ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void Conge_Maladie_Load(object sender, EventArgs e)
        {
            Increament_N();
            ttype.Enabled = false;
            dateD.Enabled = false;
            tnombre_jour.Enabled = false;
            bcalculer.Enabled = false;
            remplire_gride();
            search_withe_namme();
            charger_all_dots();
            charger_all_dots2();
            search_withe_namme_R();

            bdelete.Enabled = false;
            bupdate.Enabled = false;
        }
        private void Increament_N()
        {
            SqlCommand cmd = new SqlCommand("select top 1 N_conge from conge order by N_conge desc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int valus = int.Parse(dr[0].ToString()) + 1;
                tnconge.Text = valus.ToString();
            }
            dr.Close();
            con.Close();
        }
        private void badd_Click(object sender, EventArgs e)
        {
            try
            {
                if (badd.Text == "Ajouter")
                {
                    if (tdot.Text == "" || tnomFR.Text == "" || tdoteR.Text == "" || tnomR.Text == "")
                    {
                        MessageBox.Show("remplire les shamps SVP", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (tnombre_jour.Text == "")
                    {
                        MessageBox.Show("Selectionner la date de debut puis le duree !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        verifier_conge();
                        remplire_gride();
                        badd.Text = "Nouveau";
                    }
                }
                else

                {
                    clear();
                    Increament_N();
                    bupdate.Enabled = false;
                    bdelete.Enabled = false;
                    badd.Text = "Ajouter";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tnombre_jour_TextChanged(object sender, EventArgs e)
        {
            if (tnombre_jour.Text == "")
            {
                bcalculer.Enabled = false;
            }
            else
            {
                bcalculer.Enabled = true;
            }
        }
        public void remplire_gride()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select N_conge, N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge where id_type_c=3 ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bcalculer_Click(object sender, EventArgs e)
        {
            try
            {
                int nb_jr = int.Parse(tnombre_jour.Text);
                int nb = nb_jr - 1;

                dateF.Value = dateD.Value.Date.AddDays(nb);
                if (dateF.Value < DateTime.Now)
                {
                    MessageBox.Show("la duree selectione est inferieur a la date en cour");
                    dateF.Value = DateTime.Now;
                    tnombre_jour.Text = "";
                }
                else
                if (int.Parse(tnombre_jour.Text) >= 1 && int.Parse(tnombre_jour.Text) < 60)
                {
                    ttype.Text = "Conge Maladie de court duree";
                }
                else
                {
                    if (int.Parse(tnombre_jour.Text) >= 60 && int.Parse(tnombre_jour.Text) < 365)
                    {
                        ttype.Text = "Conge Maladie de moyenne duree";
                    }
                    else

                    if (int.Parse(tnombre_jour.Text) >= 365 && int.Parse(tnombre_jour.Text) < 730)
                    {
                        ttype.Text = "Conge Maladie de longue duree";
                    }
                }
            }
            catch (  Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void verifier_conge()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select top 1 * from Conge where id_type_c=3 and N_dote='" + tdot.Text + "' and((GETDATE() between date_D and date_F) or (GETDATE()=date_F)) order by date_F desc ", con);
                DataTable dt = new DataTable();

                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 0)
                {
                    ajouter_conge();
                }
                else
                {

                    MessageBox.Show("Imposible deffectuer ce conge");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public void ajouter_conge()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into conge (N_conge,N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c,type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement) values('" + tnconge.Text + "','" + tdot.Text + "','" + tnomAR.Text + "','" + tprenomAR.Text + "','" + dateD.Text + "','" + dateF.Text + "','" + tnombre_jour.Text + "',getdate(),3,'" + ttype.Text + "','" + tdoteR.Text + "','" + tnomRAR.Text + "','" + tprenomRAR.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //verifier_conge();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void search_withe_namme()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][1].ToString());
            }
            tnomFR.AutoCompleteCustomSource = auto;
            tnomFR.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tnomFR.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public void search_withe_namme_R()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][1].ToString());
            }
            tnomR.AutoCompleteCustomSource = auto;
            tnomR.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tnomR.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public void auto_complete()
        {
            SqlDataAdapter da = new SqlDataAdapter("select N_dote from employe", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][0].ToString());
            }
            this.tdot.AutoCompleteCustomSource = auto;
            this.tdot.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.tdot.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public void charger_all_dots()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select N_dote from employe", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    tdot.Items.Add(dr[0].ToString());
            //    tdoteR.Items.Add(dr[0].ToString());
            //}
            //con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                tdot.Items.Add(ds.Tables["emp"].Rows[i][0]);

            }
        }

        public void charger_all_dots2()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select N_dote from employe", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    tdot.Items.Add(dr[0].ToString());
            //    tdoteR.Items.Add(dr[0].ToString());
            //}
            //con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                tdoteR.Items.Add(ds.Tables["emp"].Rows[i][0]);

            }
        }

        private void tdot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "conge");
            for (int i = 0; i < ds.Tables["conge"].Rows.Count; i++)
            {
                if (tdot.SelectedItem.Equals(ds.Tables["conge"].Rows[i][0]))
                {
                    tnomFR.Text = ds.Tables["conge"].Rows[i][1].ToString();
                    tprenom.Text = ds.Tables["conge"].Rows[i][2].ToString();
                    tnomAR.Text = ds.Tables["conge"].Rows[i][3].ToString();
                    tprenomAR.Text = ds.Tables["conge"].Rows[i][4].ToString();

                }

            }
            if(tdot.Text=="" || tnomFR.Text=="")
            {
                dateD.Enabled = false;
                tnombre_jour.Enabled = false;
            }
            else
            {
                dateD.Enabled = true;
                tnombre_jour.Enabled = true;
            }
        }

        private void tdoteR_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "conge");
            for (int i = 0; i < ds.Tables["conge"].Rows.Count; i++)
            {
                if (tdoteR.SelectedItem.Equals(ds.Tables["conge"].Rows[i][0]))
                {
                    tnomR.Text = ds.Tables["conge"].Rows[i][1].ToString();
                    tprenomR.Text = ds.Tables["conge"].Rows[i][2].ToString();
                    tnomRAR.Text = ds.Tables["conge"].Rows[i][3].ToString();
                    tprenomRAR.Text = ds.Tables["conge"].Rows[i][4].ToString();

                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bdelete.Enabled == false && bupdate.Enabled == false)
                {
                    bdelete.Enabled = true; bupdate.Enabled = true;
                    badd.Text = "Nouveau";
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    tnconge.Text = dataGridView1.Rows[e.RowIndex].Cells["N_conge"].FormattedValue.ToString();
                    tdot.Text = dataGridView1.Rows[e.RowIndex].Cells["N_dote"].FormattedValue.ToString();
                    //ttypeconge.Text = dataGridView1.Rows[e.RowIndex].Cells["type_de_conge"].FormattedValue.ToString();
                    dateD.Text = dataGridView1.Rows[e.RowIndex].Cells["date_D"].FormattedValue.ToString();
                    tnombre_jour.Text = dataGridView1.Rows[e.RowIndex].Cells["Nb_jour"].FormattedValue.ToString();
                    dateF.Text = dataGridView1.Rows[e.RowIndex].Cells["date_F"].FormattedValue.ToString();
                    //dateSaisie.Text = dataGridView1.Rows[e.RowIndex].Cells["Date_saisie"].FormattedValue.ToString();
                    tdoteR.Text = dataGridView1.Rows[e.RowIndex].Cells["N_dote_remplacement"].FormattedValue.ToString();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tnomFR_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");

            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                if (tnomFR.Text.Equals(ds.Tables["emp"].Rows[i][1]))
                {
                    tdot.Text = ds.Tables["emp"].Rows[i][0].ToString();
                }
            }
        }

        private void tnomR_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");

            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                if (tnomR.Text.Equals(ds.Tables["emp"].Rows[i][1]))
                {
                    tdoteR.Text = ds.Tables["emp"].Rows[i][0].ToString();
                }
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vouler vous vraiment supprimer ce conge", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete conge where N_dote='" + tdot.Text + "' and Nom_employe ='" + tnomAR.Text + "' and date_D='" + dateD.Text + "' and date_F='" + dateF.Text + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    clear();
                }


                remplire_gride();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            tnconge.Text = "";
            tdot.Text = "";
            tnomFR.Clear();
            tprenom.Clear();
            tnomAR.Clear();
            tprenomAR.Clear();
            dateD.Value = DateTime.Now;
            dateF.Value = DateTime.Now;
            ttype.Text = "";
            tnombre_jour.Clear();
            tdoteR.Text = "";
            tnomR.Clear();
            tprenomR.Clear();
            tnomRAR.Clear();
            tprenomRAR.Clear();

        }
        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vouler vous vraiment supprimer ce conge", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update conge set N_dote='" + tdot.Text + "' ,Nom_employe='" + tnomAR.Text + "',prenom_employe='" + tprenomAR.Text + "',date_D='" + dateD.Text + "',date_F='" + dateF.Text + "',Nb_jour='" + tnombre_jour.Text + "',id_type_c=3,type_de_conge='" + ttype.Text + "',N_dote_remplacement='" + tdoteR.Text + "',Nom_remplacement='" + tnomRAR.Text + "',Prenom_remplacement='" + tprenomRAR.Text + "' where id_type_c=3 and N_conge='" + tnconge.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                remplire_gride();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
