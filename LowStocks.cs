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
    public partial class LowStocks : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public LowStocks()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void GetLowStocks()
        {
            try
            {

                dataGridView3.Rows.Clear();
                int i = 0;
                cn.Open();
                string query3 = "SELECT * FROM vwCriticalItems";
                string query = "SELECT pcode, barcode, pdesc, price, reorder, qty FROM vwCriticalItems";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i, int.Parse(dr["pcode"].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LowStocks_Load(object sender, EventArgs e)
        {

        }
    }
}
