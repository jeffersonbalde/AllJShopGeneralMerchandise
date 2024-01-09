using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_System
{
    public partial class frmAddCustomer : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmAddDebt frmAdd;

        int customerID;

        public frmAddCustomer(frmAddDebt formAddDebt)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frmAdd = formAddDebt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAddDebt_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
        }


        private void btnEnter_Click(object sender, EventArgs e)
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

                frmAdd.LoadCustomer();

                this.Dispose();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }



        //public void InsertCustomerDebt()
        //{
        //    try
        //    {
        //        cn.Open();

        //        String customer;
        //        String referenceNo;


        //        string query = "SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tblcart AS c INNER JOIN tblproduct AS p ON c.pcode = p.pcode WHERE transno LIKE '" + lblTransno.Text + "' AND status LIKE 'Pending'";
        //        cm = new SqlCommand(query, cn);
        //        dr = cm.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            total += Double.Parse(dr["total"].ToString());
        //            discount += Double.Parse(dr["disc"].ToString());
        //            hasrecord = true;
        //        }
        //        dr.Close();

        //        cn.Close();


        //        //INSERT CUSTOMERDEBT
        //        cn.Open();

        //        string query1 = "INSERT INTO CustomerDebt(Customer, ReferenceNo, Item, Price, Qty, Total, Date) VALUES(@customer, @referenceNo, @item, @price, @qty, @total, @date)";
        //        cm = new SqlCommand(query1, cn);

        //        cm.Parameters.AddWithValue("@customer", frmPOS.Text);
        //        cm.Parameters.AddWithValue("@referenceNo", txtContactNo.Text);
        //        cm.Parameters.AddWithValue("@item", txtAddress.Text);
        //        cm.Parameters.AddWithValue("@price", txtAddress.Text);
        //        cm.Parameters.AddWithValue("@qty", txtAddress.Text);
        //        cm.Parameters.AddWithValue("@total", txtAddress.Text);
        //        cm.Parameters.AddWithValue("@date", DateTime.Now);

        //        cm.ExecuteNonQuery();

        //        cn.Close();

        //    }
        //    catch(Exception ex)
        //    {
        //        cn.Close();
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Clear()
        {
            txtName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

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
    }
}
