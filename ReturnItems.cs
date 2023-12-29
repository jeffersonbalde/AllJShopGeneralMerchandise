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
    public partial class ReturnItems : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public ReturnItems()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInventoryReport frm = new frmInventoryReport();
            string query = "SELECT * FROM vwcancelledorder WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "'";
            string date = "DATE: ( " + dt1.Value.ToString("yyyy-MM-dd") + " - " + dt2.Value.ToString("yyyy-MM-dd") + " )";
            frm.LoadReturnItems(query, date);
            frm.ShowDialog();
        }

        public void VoidItems()
        {
            try
            {

                int i = 0;
                dataGridView5.Rows.Clear();
                cn.Open();
                string query = "SELECT * FROM vwcancelledorder WHERE sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView5.Rows.Add(i, dr["transno"].ToString(), int.Parse(dr["pcode"].ToString()), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["cancelledby"].ToString(), dr["action"].ToString());
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            VoidItems();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            VoidItems();
        }
    }
}
