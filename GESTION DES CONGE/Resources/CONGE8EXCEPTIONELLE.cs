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
    public partial class CONGE8EXCEPTIONELLE : Form
    {
        public CONGE8EXCEPTIONELLE()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection("data source=ABD-ASSAMAD-DES ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void CONGE8EXCEPTIONELLE_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button Add withe stored procedure
            //SqlCommand cmd = new SqlCommand("Conge_exceptionelle", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter pN_dote = cmd.Parameters.Add("@N_dote", SqlDbType.Int);
            //SqlParameter pnomemploye = cmd.Parameters.Add("@Nom_empoye", SqlDbType.VarChar, 50);
            //SqlParameter pprenomemploye = cmd.Parameters.Add("@prenom_employe", SqlDbType.VarChar, 50);
            //SqlParameter pdateD = cmd.Parameters.Add("@dateD", SqlDbType.Date);
            //SqlParameter pdateF = cmd.Parameters.Add("@dateF", SqlDbType.Date);
            //SqlParameter pnombrejour = cmd.Parameters.Add("@Nbjour", SqlDbType.Int);
            //SqlParameter pdateSaisie = cmd.Parameters.Add("@datesaisie", SqlDbType.Date);
            //SqlParameter pidtypeconge = cmd.Parameters.Add("@id_type_C", SqlDbType.Int);
            //SqlParameter ptypeconge = cmd.Parameters.Add("@type_conge", SqlDbType.VarChar, 50);
            //SqlParameter pNdoteRemplacement = cmd.Parameters.Add("@Ndote_Remplacement", SqlDbType.Int);
            //SqlParameter pnomremplacement = cmd.Parameters.Add("@Nom_remplacement", SqlDbType.VarChar, 50);
            //SqlParameter pprenomremplacement = cmd.Parameters.Add("@prenom_remplacement", SqlDbType.VarChar, 50);

            //pN_dote.Value = tdot.Text;
            //pnomemploye.Value = tnomAR.Text;
            //pprenomemploye.Value = tprenomAR.Text;
            //pdateD.Value = dateD.Value;
            //pdateF.Value = dateF.Value;
            //pnombrejour.Value = tduree.Text;
            //pdateSaisie.Value = dateSaisie.Text;
            //pidtypeconge.Value = tid_type.Text;
            //ptypeconge.Value = ttypeconge.Text;
            //pNdoteRemplacement.Value = tdoteR.Text;
            //pnomremplacement.Value = tnomRAR.Text;
            //pprenomremplacement.Value = tprenomRAR.Text;

            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //chargerGrid();
            if(badd.Text=="Ajouter")
            {
                if (tdot.Text == "" || tnomFR.Text == "" || tnomR.Text == "" || tdoteR.Text == "")
                {
                    MessageBox.Show("Remplire les sshamps SVP !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
              if (tduree.Text == "")
                {
                    MessageBox.Show("Sélectionnez la date de debut !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
              if (ttypeconge.Text == "")
                {
                    MessageBox.Show("Sélectionnez la un type de conge !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    verifier_conge();
                    chargerGrid();

                    badd.Text = "Nouveau";
                }

            }
            else
            {
                tdot.Text = "";
                tnomFR.Clear();
                tprenom.Clear();
                tnomAR.Clear();
                tprenomAR.Clear();
                tdoteR.Text = "";
                tnomR.Clear();
                tprenomR.Clear();
                tnomRAR.Clear();
                tprenomRAR.Clear();
                tduree.Clear();
                dateD.Value = DateTime.Now;
                dateF.Value = DateTime.Now;
                ttypeconge.Text = "";
                bupdate.Enabled = false;
                bdelete.Enabled = false;
                bprint.Enabled = false;
                badd.Text = "Ajouter";
            }

        }

        public void verifier_conge()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select top 1 * from Conge where id_type_c=2 and N_dote='" + tdot.Text + "' and(GETDATE() between date_D and date_F) or (GETDATE()=date_F) order by date_F desc ", con);
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
        public void ajouter_conge()
        {
            SqlCommand cmd = new SqlCommand("insert into conge (N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c,type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement) values('" + tdot.Text +
                "','" + tnomAR.Text + "','" + tprenomAR.Text + "','" + dateD.Text + "','" + dateF.Text + "','" + tduree.Text + "','"+dateSaisie.Text+"',2,'" + ttypeconge.Text.Replace("'", "''")+ "','" + tdoteR.Text + "','" + tnomRAR.Text + "','" + tprenomRAR.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //verifier_conge();

        }

        public void chargerGrid()
        {
           

            SqlCommand cmd = new SqlCommand("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge where id_type_c=2 ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;
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

        public void charger_type()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Detaille_Type_conge where id_type=2", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ttypeconge.Items.Add(dr[1].ToString());
                
            }
            con.Close();
        }

        // calculer la duree
        public void calculer_durer()
        {

            DateTime dt = dateD.Value.Date;
            DateTime dtt = dateF.Value.Date;
            TimeSpan ts = dtt - dt;
            int days = ts.Days + 1;
            tduree.Text = days.ToString();
        }

        private void dateF_ValueChanged(object sender, EventArgs e)
        {
            calculer_durer();
        }

        public void calculer_dateF()
        {

            try
            {
                if (ttypeconge.SelectedItem.ToString() == "Mariage de l'agent")
                {
                    dateF.Value = dateD.Value.AddDays(9);

                }
                else
                   if (rhomme.Checked == true)
                {
                    dateF.Value = dateD.Value.AddDays(2);
                }
                else
                       if (rfemmme.Checked == true)
                {
                    dateF.Value = dateD.Value.AddDays(97);
                }
                else
                   if (ttypeconge.SelectedItem.ToString() == "Mariage d'un enfant" || ttypeconge.SelectedItem.ToString() == "Décès du conjoint")
                {
                    dateF.Value = dateD.Value.AddDays(2);
                }
                else
                       if (ttypeconge.SelectedItem.ToString() == "Décès d'un frère ou d'une soeur" || ttypeconge.SelectedItem.ToString() == "Déménagement" || ttypeconge.SelectedItem.ToString() == " l'hospitalisation du conjoint ")
                {
                    dateF.Value = dateD.Value.AddDays(1);
                }
                else
                       if (ttypeconge.SelectedItem.ToString() == "Circoncision d'un enfant")
                {
                    dateF.Value = dateD.Value.AddDays(0);
                }
            }
            catch (Exception)
            {
                tduree.Text = "";
                MessageBox.Show("Erreur");
            }
        }

        private void dateD_ValueChanged(object sender, EventArgs e)
        {
            calculer_dateF();
        }

        private void ttypeconge_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateD.Value = DateTime.Now;
            dateF.Value = DateTime.Now;
            tduree.Text = "";
            if (ttypeconge.SelectedItem.ToString() == "Naissence d'un enfant")
            {
                groupBox1.Visible = true;
            }
            else
                groupBox1.Visible = false;

          
        }

        private void rhomme_CheckedChanged(object sender, EventArgs e)
        {
            dateD.Value = DateTime.Now;
            dateF.Value = DateTime.Now;
            tduree.Text = "";
        }

        private void rfemmme_CheckedChanged(object sender, EventArgs e)
        {
            dateD.Value = DateTime.Now;
            dateF.Value = DateTime.Now;
            tduree.Text = "";
        }

        public void cree_conge()
        {

            SqlCommand cmd = new SqlCommand("insert into conge(N_dote,Nom_employe,prenom_employe,date_D,date_F,Nb_jour,Date_saisie,id_type_c,type_de_conge,N_dote_remplacement,Nom_remplacement,Prenom_remplacement) values('" + tdot.Text +
                "','" + tnomAR.Text + "','" + tprenomAR.Text + "','" + dateD.Text + "','" + dateF.Text + "','" + tduree.Text + "','" + dateSaisie.Text + "',2,'" + ttypeconge.Text.Replace("'", "''") + "','" + tdoteR.Text + "','" + tnomRAR.Text + "','" + tprenomRAR.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ajouter avec succes !");
            //ds.Tables["conge"].Rows.Add(tdot.Text, tnomAR.Text, tprenomAR.Text, dateD.Text, dateF.Text, tduree.Text, dateSaisie.Text, tid_type.Text, ttypeconge.Text.Replace("'", "''"), tdoteR.Text, tnomRAR.Text, tprenomRAR.Text);
            //button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rhomme.Checked)
            {
                imprimer1();
            }
            else
              if (rfemmme.Checked)
            {
                imprimer2();
            }
            else
              if (ttypeconge.SelectedItem.ToString() == "Mariage de l'agent")
            {
                mariage();
            }
        }
        public void imprimer1()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from conge where N_dote='" + tdot.Text + "'", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "conge");
            report r1 = new report();
            r1.SetDataSource(ds);
            christal_report f = new christal_report(r1);
            f.Show();
            con.Close();
        }
        //imprimer 2
        public void imprimer2()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from conge where N_dote='" + tdot.Text + "'", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "conge");
            report_F r2 = new report_F();
            r2.SetDataSource(ds);
            christal_report f = new christal_report(r2);
            f.Show();
            con.Close();
        }

        //mariage
        public void mariage()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from conge where N_dote='" + tdot.Text + "'", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "conge");
            Mariiage m = new Mariiage();
            m.SetDataSource(ds);
            christal_report f = new christal_report(m);
            f.Show();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                tdot.Text = dataGridView1.Rows[e.RowIndex].Cells["N_dote"].FormattedValue.ToString();
                ttypeconge.Text = dataGridView1.Rows[e.RowIndex].Cells["type_de_conge"].FormattedValue.ToString();
                dateD.Text = dataGridView1.Rows[e.RowIndex].Cells["date_D"].FormattedValue.ToString();
                dateF.Text = dataGridView1.Rows[e.RowIndex].Cells["date_F"].FormattedValue.ToString();
                dateSaisie.Text = dataGridView1.Rows[e.RowIndex].Cells["Date_saisie"].FormattedValue.ToString();
                tdoteR.Text = dataGridView1.Rows[e.RowIndex].Cells["N_dote_remplacement"].FormattedValue.ToString();

                groupBox1.Visible = false;
                bdelete.Enabled = true;
                bupdate.Enabled = true;
                bprint.Enabled = true;
                badd.Text = "Nouveau";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vraiment supprimer le conge de l'employe", "important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete conge where N_dote='" + tdot.Text + "' and date_D='" + dateD.Text + "'and date_F='" + dateF.Text + "' and Date_saisie='" + dateSaisie.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            chargerGrid();
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

            //SqlCommand cmd = new SqlCommand("select * from employe", con);
            //con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            //while(dr.Read())
            //{
            //    auto.Add(dr.GetString(1));
            //}
            //tnom.AutoCompleteMode = AutoCompleteMode.Suggest;
            //tnom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //tnom.AutoCompleteCustomSource = auto;
            //con.Close();

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

        private void bupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
