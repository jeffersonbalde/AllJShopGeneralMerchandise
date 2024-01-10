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
    public partial class CustomerDetails : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public CustomerDetails()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearchProduct;
        }

        public void LoadCustomerInformation()
        {
            try
            {

                cn.Open();
                int i = 0;
                dataGridView1.Rows.Clear();
                string query = "SELECT * FROM CustomerInformation WHERE Name LIKE '" + txtSearchProduct.Text + "%' ORDER BY Name";

                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["Name"].ToString(), dr["ContactNo"].ToString(), dr["Address"].ToString());
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

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerInformation();
        }

        private void CustomerDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
