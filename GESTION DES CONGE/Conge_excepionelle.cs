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
    public partial class Conge_excepionelle : Form
    {
        public Conge_excepionelle()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(@"data source=zz\sqlExpress ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void badd_Click(object sender, EventArgs e)
        {

            try
            {
                if (badd.Text == "Ajouter")
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

                        verifier_duree_conge();
                        chargerGrid();

                        badd.Text = "Nouveau";
                    }
                    bupdate.Enabled = true;
                    bdelete.Enabled = true;
                    bprint.Enabled = true;

                }
                else
                {

                    clear();
                    Increament_N();
                    bupdate.Enabled = false;
                    bdelete.Enabled = false;
                    bprint.Enabled = false;
                    badd.Text = "Ajouter";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Increament_N()
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
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
            tduree.Text = ""; 
            dateD.Value = DateTime.Now;
            dateF.Value = DateTime.Now;
            ttypeconge.Text = "";
        }
        public void verifier_conge()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select top 1 * from Conge where id_type_c=2 and N_dote='" + tdot.Text + "'  and((GETDATE()<='" + dateD.Text + "') or (GETDATE() between date_D and date_F) or (GETDATE()=date_F)) order by N_conge desc  ", con);
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
        public void verifier_duree_conge()
        {
            con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c where c.id_type_c=2 group by N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement having sum(c.Nb_jour) >=10 ", con);
            SqlDataAdapter da = new SqlDataAdapter("select N_dote from conge c where c.id_type_c=2 and N_dote='"+tdot.Text+"' group by N_dote having sum(Nb_jour)>=10 ", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if(dt.Rows.Count==0)
            {
                verifier_conge();
            }
            else
            {
                if(MessageBox.Show("Vous avez dépassé le nombre autorisé Voulez vous Ajouter ce conge quand memme ?","Comfirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                {
                    verifier_conge();
                }
               
            }
        }
        public void ajouter_conge()
        {
            SqlCommand cmd = new SqlCommand("insert into conge (N_conge,N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c,type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement) values('"+tnconge.Text+"','" + tdot.Text +
                "','" + tnomAR.Text + "','" + tprenomAR.Text + "','" + dateD.Text + "','" + dateF.Text + "','" + tduree.Text + "','" + dateSaisie.Text + "',2,'" + ttypeconge.Text.Replace("'", "''") + "','" + tdoteR.Text + "','" + tnomRAR.Text + "','" + tprenomRAR.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //verifier_conge();

        }

        public void chargerGrid()
        {


            try
            {
                SqlCommand cmd = new SqlCommand("select N_conge, N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge where id_type_c=2 ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            if (tdot.Text == "" || tnomFR.Text == "")
            {
                ttypeconge.Enabled = false;
            }
            else
            {
                ttypeconge.Enabled = true;
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
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                   if (rhomme.Checked)
                {
                    dateF.Value = dateD.Value.AddDays(2);
                }
                else
                       if (rfemmme.Checked)
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

            if (ttypeconge.Text == "")
            {
                dateD.Enabled = false;
            }
            else
            {
                dateD.Enabled = true;
            }
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

            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bprint_Click(object sender, EventArgs e)
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
            else
            {
                imprimer();
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
            SqlDataAdapter da = new SqlDataAdapter(" select * from conge c inner join employe e on e.N_dote=c.N_dote where N_conge='"+tnconge.Text+"'", con);
            da = new SqlDataAdapter(" select * from employe e inner join conge c on e.N_dote=c.N_dote", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employe");
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
            SqlDataAdapter da = new SqlDataAdapter("select * from conge where N_conge='" + tnconge.Text + "'", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "conge");
            Mariiage m = new Mariiage();
            m.SetDataSource(ds);
            christal_report f = new christal_report(m);
            f.Show();
            con.Close();
        }
        public void imprimer()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from conge where N_conge='"+tnconge.Text+"'", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "conge");
            CrystalReport2 m = new CrystalReport2();
            m.SetDataSource(ds);
            christal_report f = new christal_report(m);
            f.Show();
            con.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    tnconge.Text = dataGridView1.Rows[e.RowIndex].Cells["N_conge"].FormattedValue.ToString();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("voulez vous vraiment supprimer le conge de l'employe", "important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete conge where N_conge='" + tnconge.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                clear();
                chargerGrid();
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

        private void Conge_excepionelle_Load(object sender, EventArgs e)
        {
            Increament_N();
            ttypeconge.Enabled = false;
            dateD.Enabled = false;
           
           
            chargerGrid();
            charger_all_dots();
            charger_all_dots2();
            charger_type();
            dateF.Enabled = false;
            groupBox1.Visible = false;
            //  auto_complete();
            //button2.Visible = false;
           
            search_withe_namme();
            search_withe_namme_R();
            bdelete.Enabled = false;
            bupdate.Enabled = false;
            bprint.Enabled = false;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous modifier le conge ?", "important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update conge set N_dote='" + tdot.Text + "' ,Nom_employe='" + tnomAR.Text + "',prenom_employe='" + tprenomAR.Text + "',date_D='" + dateD.Text + "',date_F='" + dateF.Text + "',Nb_jour='" + tduree.Text + "',Date_saisie=getdate(),id_type_c=2,type_de_conge='Exceptionelle',N_dote_remplacement='" + tdoteR.Text + "',Nom_remplacement='" + tnomRAR.Text + "',Prenom_remplacement='" + tprenomRAR.Text + "' where id_type_c=2 and N_conge='" + tnconge.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    chargerGrid();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
