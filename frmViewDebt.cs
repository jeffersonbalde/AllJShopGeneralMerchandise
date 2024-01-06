﻿using System;
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
                string query = "SELECT p.pdesc, c.transno, c.price, c.qty, c.disc, c.total, c.sdate, d.Name FROM tblCart AS c INNER JOIN tblProduct AS p ON p.pcode = c.pcode INNER JOIN CustomerInformation AS d ON c.customerID = D.ID WHERE c.status = 'Debt' AND d.Name LIKE '" + txtSearchProduct.Text + "%' ORDER BY d.Name";

                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["Name"].ToString(), dr["transno"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), Double.Parse(dr["disc"].ToString()).ToString("#,##0.00"), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"), dr["sdate"].ToString());
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
            this.ActiveControl = txtSearchProduct;

        }
    }
}
