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
    public partial class Service_statistique : Form
    {
        public Service_statistique()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlDataAdapter da2;
        DataSet ds;

        public static SqlConnection con = new SqlConnection("data source=ABD-ASSAMAD-DES ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");
        private void Service_statistique_Load(object sender, EventArgs e)
        {


            //  con.Open();
            //  SqlDataAdapter da = new SqlDataAdapter("select * from devision", con);
            //  da.Fill(ds, "devision");
            //  DataColumn[] dc = new DataColumn[1];
            //  dc[0] = ds.Tables["devision"].Columns[0];
            //  ds.Tables["devision"].PrimaryKey = dc;

            //  //table service

            //  da = new SqlDataAdapter("select * from service", con);
            //  da.Fill(ds, "service");
            //  dc = new DataColumn[1];
            //  dc[0] = ds.Tables["service"].Columns[0];
            //  ds.Tables["service"].PrimaryKey = dc;
            //  //les relations
            // // ds.Relations.Add("fk_dv_ser", ds.Tables["devision"].Columns[0], ds.Tables["service"].Columns[3]);
            //  con.Close();

            //  bsDivision.DataSource =ds;
            //  bsDivision.DataMember = "devision";

            //  bsService.DataSource = bsDivision;
            ////  bsService.DataMember = "fk_dv_ser";

            //  dataGridView1.DataSource = bsDivision;
            //  dataGridView2.DataSource = bsService;

           da = new SqlDataAdapter("select * from devision", con);
            da2 = new SqlDataAdapter("select * from service", con);
           ds = new DataSet();
            da.Fill(ds, "devision");
            da2.Fill(ds, "service");

            ds.Tables["devision"].Constraints.Add("devisionID_pk", ds.Tables["devision"].Columns["id_devision"], true);
            ds.Relations.Add("devision_service", ds.Tables["devision"].Columns["id_devision"], ds.Tables["service"].Columns["id_devision"]);
            dataGridView1.DataSource = ds.Tables["devision"];

            childData(0);
        }
        public void childData(int rowIndex)
        {
            var parentRow = ds.Tables["devision"].Rows[rowIndex];
            var childRow = parentRow.GetChildRows("devision_service");
            DataTable childTable = ds.Tables["service"].Clone();
            foreach(var row in childRow)
            {
                childTable.ImportRow(row);
            }
            dataGridView2.DataSource = childTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            childData(dataGridView1.CurrentRow.Index);
        }
    }
}
