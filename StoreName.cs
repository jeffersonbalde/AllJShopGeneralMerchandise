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
    public partial class StoreName : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public StoreName()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadRecords()
        {
            try
            {
                cn.Open();
                string query = "SELECT * FROM tblstore";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtName.Text = dr["Name"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtAddress.Clear();
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this store?", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    int count = 0;
                    cn.Open();
                    string query = "SELECT COUNT(*) FROM tblstore";
                    cm = new SqlCommand(query, cn);
                    count = int.Parse(cm.ExecuteScalar().ToString());
                    cn.Close();

                    if(count > 0)
                    {
                        cn.Open();
                        string query1 = "UPDATE tblstore SET Name = @txtName, Address = @txtAddress";
                        cm = new SqlCommand(query1, cn);
                        cm.Parameters.AddWithValue("@txtName", txtName.Text);
                        cm.Parameters.AddWithValue("txtAddress", txtAddress.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    else
                    {
                        cn.Open();
                        string query1 = "INSERT INTO tblstore VALUES(@txtName, @txtAddress)";
                        cm = new SqlCommand(query1, cn);
                        cm.Parameters.AddWithValue("@txtName", txtName.Text);
                        cm.Parameters.AddWithValue("txtAddress", txtAddress.Text);
                        cm.ExecuteNonQuery();   
                        cn.Close();
                    }

                    MessageBox.Show("Store saved.", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
