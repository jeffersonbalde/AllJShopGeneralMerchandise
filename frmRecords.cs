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
                dataGridView1.Rows.Clear();

                int i = 0;
                cn.Open();
                //Top 10 products only
                //string query = "SELECT top 10 pcode, pdesc, SUM(qty) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC";
                string query = "SELECT pcode, pdesc, SUM(qty) AS qty FROM vwSoldItems WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC";
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
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();

                int i = 0;
                cn.Open();
                //string query = "SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY c.pcode, p.pdesc c.price";
                string query1 = "SELECT c.pcode, p.pdesc, c.price, SUM(c.qty) AS tot_qty, SUM(c.disc) AS tot_disc, SUM(c.total) AS total FROM tblcart AS c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "' GROUP BY c.pcode, p.pdesc, c.price";
                cm = new SqlCommand(query1, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView2.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["tot_qty"].ToString(), dr["tot_disc"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }

                dr.Close();
                cn.Close();

                cn.Open();
                string query2 = "SELECT ISNULL(SUM(total),0) FROM tblcart WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt3.Value.ToString("yyyy-MM-dd") + "' AND '" + dt4.Value.ToString("yyyy-MM-dd") + "'";
                cm = new SqlCommand(query2, cn);
                lblTotal.Text = Double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadCriticalItems()
        {
            try
            {

                dataGridView3.Rows.Clear();
                int i = 0;
                cn.Open();
                string query3 = "SELECT * FROM vwCriticalItems";
                cm = new SqlCommand(query3, cn);
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
