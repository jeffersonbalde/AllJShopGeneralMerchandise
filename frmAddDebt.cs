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

        private String pcode;
        private double price;
        private String transno;
        private int qty;
        private double total;

        public frmAddDebt(frmPOS form, frmSettle form2)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frmPOS = form;
            frmSettle = form2;
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
                string query1 = "SELECT ID FROM CustomerInformation WHERE Name like '" + comboBoxCustomer.Text + "'";
                cm = new SqlCommand(query1, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    customerID = int.Parse(dr[0].ToString());
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
            InsertTblCart();
            frmSettle.DebtUpdateQuantity();

            frmPOS.GetTransNo();
            frmPOS.LoadCart();
            frmPOS.LoadRecords();

            MessageBox.Show("Debt saved to " + comboBoxCustomer.Text + ".", "ADD DEBT", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
