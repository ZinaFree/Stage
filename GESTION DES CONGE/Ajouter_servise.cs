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
    public partial class Ajouter_servise : Form
    {
        public Ajouter_servise()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=ABD-ASSAMAD-DES ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void button1_Click(object sender, EventArgs e)
        {

            if (tidservice.Text != "" && tservice.Text != "" && checkBox1.Checked == true && tdevisionFR.Text != "" && tidservice.Text != "" && tdevisionAR.Text != "")
            {

                insert_service_devision();
            }
            else
               if (tidservice.Text != "" && tservice.Text != "" && tserviceAR.Text != "" && checkBox1.Checked == false)
            {
                insert_service();
            }
            else
            {
                MessageBox.Show("Remplire les shamps SVP !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


            chargerGrid_S();





            chargerGrid_S();
        }

        private void Ajouter_servise_Load(object sender, EventArgs e)
        {
            remplire_combo_id_division();

            chargerGrid_S();

            // Autocomplete();
            groupBox3.Visible = false;
        }
        public void chargerGrid_S()
        {

            SqlCommand cmd = new SqlCommand("select * from service", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            con.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox3.Visible == false)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        public void remplire_combo_id_division()
        {

            SqlCommand cmd = new SqlCommand("select * from devision", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tid_devision.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void insert_service_devision()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into service values('" + tidservice.Text + "','" + tservice.Text.Replace("'", "''") + "','" + tserviceAR.Text + "','" + tid_devision.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("erreur d'insertion");
            }

        }
        //insert service only
        public void insert_service()
        {


            try
            {
                SqlCommand cmd = new SqlCommand("insert into service(id_service,libelle_S_FR,libelle_S_AR) values('" + tidservice.Text + "','" + tservice.Text.Replace("'", "''") + "','" + tserviceAR.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                chargerGrid_S();
            }
            catch (Exception)
            {

                MessageBox.Show("erreur d'insertion");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update service set libelle_S_FR='" + tservice.Text + "',libelle_S_AR='" + tserviceAR.Text + "','" + tidservice.Text + "'", con);
            cmd.ExecuteReader();
            con.Close();
            chargerGrid_S();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete service where id_service='" + tidservice.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            chargerGrid_S();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    tidservice.Text = dataGridView1.Rows[e.RowIndex].Cells["id_service"].FormattedValue.ToString();
                    tservice.Text = dataGridView1.Rows[e.RowIndex].Cells["libelle_S_FR"].FormattedValue.ToString();
                    tserviceAR.Text = dataGridView1.Rows[e.RowIndex].Cells["libelle_S_AR"].FormattedValue.ToString();
                    tid_devision.Text = dataGridView1.Rows[e.RowIndex].Cells["id_devision"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tid_devision_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from devision where id_devision='" + tid_devision.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string devFR = (string)dr[1].ToString();
                tdevisionFR.Text = devFR;
                string devAR = (string)dr[2].ToString();
                tdevisionAR.Text = devAR;

            }
            dr.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tidservice.Clear();
            tservice.Clear();
            tserviceAR.Clear();
        }
    }
}
