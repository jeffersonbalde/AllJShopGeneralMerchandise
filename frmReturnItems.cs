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
    public partial class frmReturnItems : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmReturnItems()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            this.KeyPreview = true;
        }

        private void frmReturnItems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void frmReturnItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
