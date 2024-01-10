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
    public partial class CompletePayment : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        CashierItemSales frmCashierSales;
        ManageCustomer frmManageCustomer;

        int CustomerID;

        public CompletePayment(CashierItemSales frm, ManageCustomer form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frmCashierSales = frm;
            frmManageCustomer = form;

            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void GetCustomerID()
        {
            try
            {

                cn.Open();
                string query = "SELECT c.customerID, d.Name FROM CustomerInformation AS d INNER JOIN tblCart AS c ON c.customerID = d.ID WHERE d.Name LIKE '" + comboBoxCustomer.Text + "'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    CustomerID = int.Parse(dr["customerID"].ToString());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxCustomer.Text == "")
                {
                    MessageBox.Show("Please select customer in the combobox", "COMPLETE PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                cn.Open();
                string query = "UPDATE tblCart SET status = 'Sold' WHERE CustomerID = @CustomerID";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@CustomerID", CustomerID);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Customer " + comboBoxCustomer.Text + " paid", "COMPLETE PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(frmCashierSales != null)
                {
                    frmCashierSales.LoadRecord();
                }

                if(frmManageCustomer != null)
                {
                    frmManageCustomer.LoadCustomerName();
                }
                this.Dispose();

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustomerID();
        }

        public void LoadCustomerName()
        {
            try
            {
                comboBoxCustomer.Items.Clear();
                cn.Open();
                string query = "SELECT Name FROM CustomerInformation";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxCustomer.Items.Add(dr["Name"].ToString());
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

        private void comboBoxCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CompletePayment_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBoxCustomer;
        }

        private void CompletePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
