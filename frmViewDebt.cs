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
    public partial class frmViewDebt : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmViewDebt()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCustomer()
        {
            try
            {
                cn.Open();
                int i = 0;
                dataGridView1.Rows.Clear();

                // Initialize SqlCommand with an initial query
                cm = new SqlCommand("SELECT p.pdesc, c.transno, c.price, c.qty, c.disc, c.total, c.sdate, d.Name FROM tblCart AS c INNER JOIN tblProduct AS p ON p.pcode = c.pcode INNER JOIN CustomerInformation AS d ON c.customerID = D.ID WHERE c.status = 'Debt' ORDER BY d.Name", cn);

                if (cboCashier.Text == "All")
                {
                    // Modify the query if needed
                    cm.CommandText = "SELECT p.pdesc, c.transno, c.price, c.qty, c.disc, c.total, c.sdate, d.Name FROM tblCart AS c INNER JOIN tblProduct AS p ON p.pcode = c.pcode INNER JOIN CustomerInformation AS d ON c.customerID = D.ID WHERE c.status = 'Debt' ORDER BY d.Name";
                }

                if (cboCashier.Text != "All" && cboCashier.SelectedItem != null)
                {
                    // Modify the query if needed
                    cm.CommandText = "SELECT p.pdesc, c.transno, c.price, c.qty, c.disc, c.total, c.sdate, d.Name FROM tblCart AS c INNER JOIN tblProduct AS p ON p.pcode = c.pcode INNER JOIN CustomerInformation AS d ON c.customerID = D.ID WHERE c.status = 'Debt' AND d.Name LIKE '" + cboCashier.SelectedItem.ToString() + "' ORDER BY d.Name";
                }

                // Now that cm is initialized, execute the query
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["Name"].ToString(), dr["transno"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), Double.Parse(dr["disc"].ToString()).ToString("#,##0.00"), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"), dr["sdate"].ToString());
                }
                dr.Close();
                cn.Close();

                GetTotalCustomerDebt("SELECT ISNULL(SUM(c.total),0) AS total, d.Name FROM tblCart AS c INNER JOIN CustomerInformation AS d ON c.customerID = d.ID WHERE d.Name LIKE '" + cboCashier.Text + "' AND status = 'Debt' GROUP BY d.Name");
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            CustomerDetails frm = new CustomerDetails();
            frm.LoadCustomerInformation();
            frm.ShowDialog();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void frmViewDebt_Load(object sender, EventArgs e)
        {

        }

        public void DefaultCustomerDebtTotal()
        {
            try
            {
                cn.Open();

                string query = "SELECT ISNULL(SUM(total),0.00) AS total FROM tblCart WHERE status LIKE 'Debt';";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    labelTotalItem.Text = double.Parse(dr["total"].ToString()).ToString("#,##0.00");
                }
                else
                {
                    labelTotalItem.Text = "0.00";
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

        public void GetTotalCustomerDebt(string SQLquery)
        {
            try
            {
                cn.Open();
                if(cboCashier.SelectedItem != null)
                {

                    string query = SQLquery;
                    cm = new SqlCommand(query, cn);
                    dr = cm.ExecuteReader();

                    if (cboCashier.Text == "All")
                    {
                        cm.CommandText = "SELECT ISNULL(SUM(total), 0.00) AS total FROM tblCart WHERE status LIKE 'Debt';";
                        dr.Close();
                        dr = cm.ExecuteReader();
                    }

                    if (dr.Read())
                    {
                        labelTotalItem.Text = double.Parse(dr["total"].ToString()).ToString("#,##0.00");
                    }
                    else
                    {
                        labelTotalItem.Text = "0.00";
                    }

                    dr.Close();

                }
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void labelTotalItem_Click(object sender, EventArgs e)
        {

        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTotalCustomerDebt("SELECT ISNULL(SUM(c.total),0.00) AS total, d.Name FROM tblCart AS c INNER JOIN CustomerInformation AS d ON c.customerID = d.ID WHERE d.Name LIKE '" + cboCashier.Text + "' AND status = 'Debt' GROUP BY d.Name");
            LoadCustomer();
        }

        private void cboCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void LoadCustomerName()
        {
            try
            {
                cboCashier.Items.Clear();
                cboCashier.Items.Add("All");
                cn.Open();
                string query = "SELECT Name FROM CustomerInformation";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cboCashier.Items.Add(dr["Name"].ToString());
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmViewDebt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
