using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_System
{
    public partial class frmAddDebt : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        int customerID;

        frmPOS frmPOS;
        frmSettle frmSettle;
        frmAddCustomer frmAddC;

        private String pcode;
        private double price;
        private String transno;
        private int qty;
        private double total;
        
        public frmAddDebt(frmPOS form, frmSettle form2, frmAddCustomer frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frmPOS = form;
            frmSettle = form2;
            frmAddC = frm;

            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCustomer()
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

        public void GetCustomerID()
        {
            try
            {
                //CUSTOMER ID
                cn.Open();
                string query1 = "SELECT ID FROM CustomerInformation WHERE Name LIKE '" + comboBoxCustomer.Text + "'";
                cm = new SqlCommand(query1, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    customerID = int.Parse(dr["ID"].ToString());
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

        public void DebtProductDetails(String pcode, double price, String transno, int qty, double total)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        public void InsertTblCart()
        {
            try
            {
                cn.Open();
                string query = "INSERT INTO tblcart (transno, pcode, price, qty, disc, total, sdate, cashier, customerID)VALUES(@transno, @pcode, @price, @qty, @disc, @total, @sdate, @cashier, @customerID)";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@pcode", pcode);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", frmPOS.lblUser.Text); 
                cm.ExecuteNonQuery();
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

                if (comboBoxCustomer.Text == "")
                {
                    MessageBox.Show("Please select customer in the combobox", "COMPLETE PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cn.Open();
                string query1 = "SELECT ID FROM CustomerInformation WHERE Name = @CustomerName";
                cm = new SqlCommand(query1, cn);
                cm.Parameters.AddWithValue("@CustomerName", comboBoxCustomer.Text);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    customerID = Convert.ToInt32(dr["ID"]);
                }

                dr.Close();
                cn.Close();

                cn.Open();
                string query = "UPDATE tblCart SET customerID = @customerID WHERE transno = @Transno";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@customerID", customerID);
                cm.Parameters.AddWithValue("@Transno", frmPOS.lblTransno.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                frmSettle.DebtUpdateQuantity();
                frmPOS.GetTransNo();
                frmPOS.LoadCart();
                frmPOS.LoadRecords();

                MessageBox.Show("Debt saved to " + comboBoxCustomer.Text + ".", "ADD DEBT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSettle.Dispose();
                this.Dispose();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer(this);
            frm.ShowDialog();
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmAddDebt_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBoxCustomer;
        }

        private void frmAddDebt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F1)
            {
                button16_Click(sender, e);
            }
        }
    }
}
