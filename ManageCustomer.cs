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
    public partial class ManageCustomer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public ManageCustomer()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            this.KeyPreview = true;
        }

        public void LoadCustomerName()
        {
            try
            {

                cn.Open();
                int i = 0;
                dataGridView1.Rows.Clear();
                string query = "SELECT * FROM CustomerInformation WHERE Name LIKE '" + txtSearch.Text + "%' ORDER BY Name";

                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["Name"].ToString(), dr["ContactNo"].ToString(), dr["Address"].ToString(), int.Parse(dr["ID"].ToString()));
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearch;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerName();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UpdateCustomer frm = new UpdateCustomer(this);

                frm.txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtContactNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                frm.customerID.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                frm.ShowDialog();   
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "DELETE CUSTOMER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "DELETE FROM CustomerInformation WHERE ID LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "'";
                    cm = new SqlCommand(query, cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadCustomerName();
                    LoadTotalCustomer();
                    MessageBox.Show("Customer deleted.", "DELETE ITEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AdminAddCustomer frm = new AdminAddCustomer(this);
            frm.ShowDialog();
        }

        private void ButtonMCategory_Click(object sender, EventArgs e)
        {
            frmViewDebt frm = new frmViewDebt();
            frm.LoadCustomer();
            frm.DefaultCustomerDebtTotal();
            frm.cboCashier.Text = "All";
            frm.LoadCustomerName();
            frm.ShowDialog();
        }

        private void ButtonSItem_Click(object sender, EventArgs e)
        {
            CompletePayment frm = new CompletePayment(null, this);
            frm.LoadCustomerName();
            frm.ShowDialog();
        }

        public void LoadTotalCustomer()
        {
            try
            {
                cn.Open();
                string query = "SELECT ISNULL(COUNT(*), 0) AS total FROM CustomerInformation;";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    labelTotalItem.Text = dr["total"].ToString();
                }
                else
                {
                    labelTotalItem.Text = "0";
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

        private void ManageCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnAddItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                ButtonMCategory_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                ButtonSItem_Click(sender, e);
            }
        }
    }
}
