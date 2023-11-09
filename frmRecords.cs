using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_System
{
    public partial class frmRecords : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmRecords()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadRecord()
        {
            try
            {
                int i = 0;
                cn.Open();
                string query = "SELECT pcode, pdesc, SUM(qty) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while(dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString());
                }

                dr.Close();
                cn.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }
    }
}
