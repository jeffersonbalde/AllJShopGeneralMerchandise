using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_System
{
    public partial class AdminAddCustomer : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        ManageCustomer frm;

        public AdminAddCustomer(ManageCustomer form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frm = form;

            this.KeyPreview = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AdminAddCustomer_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txtName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtContactNo.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Please fill up all fields", "ADD DEBT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                cn.Open();

                string query = "INSERT INTO CustomerInformation (Name, ContactNo, Address) VALUES(@name, @contactno, @address)";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.Parameters.AddWithValue("@contactno", txtContactNo.Text);
                cm.Parameters.AddWithValue("@address", txtAddress.Text);
                cm.ExecuteNonQuery();

                MessageBox.Show("Customer information saved.", "ADD DEBT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                cn.Close();

                frm.LoadCustomerName();
                frm.LoadTotalCustomer();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            if (e.KeyChar == 46)
            {
                //accept . character
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //accept code 48-57 between 0-9
            {
                e.Handled = true;
            }
        }

        private void AdminAddCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(sender, e);
            }
        }
    }
}
