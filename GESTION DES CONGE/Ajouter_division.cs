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
    public partial class Ajouter_division : Form
    {
        public Ajouter_division()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=ABD-ASSAMAD-DES ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void Ajouter_division_Load(object sender, EventArgs e)
        {
            chargerGrid_D();
        }
        public void chargerGrid_D()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id_devision,libelle_D_FR,libelle_D_AR from devision", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into devision values('" + idDevision.Text + "','" + devision.Text.Replace("'", "''") + "','" + devisionAR.Text + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();
                chargerGrid_D();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update devision set libelle_D_FR='" + devision.Text + "', libelle_D_AR='" + devisionAR.Text + "' where Id_devision='" + idDevision.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            chargerGrid_D();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer c'ette devision", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete devision where Id_devision='" + idDevision.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                chargerGrid_D();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    idDevision.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_devision"].FormattedValue.ToString();
                    devision.Text = dataGridView1.Rows[e.RowIndex].Cells["libelle_D_FR"].FormattedValue.ToString();
                    devisionAR.Text = dataGridView1.Rows[e.RowIndex].Cells["libelle_D_AR"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
