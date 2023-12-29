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
    public partial class frmTopItems : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmTopItems()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadRecord()
        {
            try
            {
                int i = 0;
                cn.Open();
                dataGridView1.Rows.Clear();
                if (cboSort.Text == "QUANTITY")
                {
                    cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                }
                else if (cboSort.Text == "TOTAL")
                {
                    cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", cn);
                }
                else
                {
                    cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                }
                //Top 10 products only
                //string query = "SELECT top 10 pcode, pdesc, SUM(qty) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC";
                //cm = new SqlCommand("SELECT pcode, pdesc, ISNULL(SUM(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
                //cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr["pdesc"].ToString(), dr["qty"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }

                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }
    }
}
