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
    public partial class AdminReturnForm : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmSoldItems frm;
        Form1 form1;

        public AdminReturnForm(frmSoldItems f, Form1 form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            frm = f;
            form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SaveCancelOrder()
        {
            try
            {
                cn.Open();
                string query1 = "INSERT INTO tblcancel (transno, pcode, price, qty, sdate, cancelledby, action) VALUES (@transno, @pcode, @price, @qty, @sdate, @cancelledby, @action)";
                cm = new SqlCommand(query1, cn);
                cm.Parameters.AddWithValue("@transno", txtTransnoNo.Text);
                cm.Parameters.AddWithValue("@pcode", txtPCode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(txtCancelQty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cancelledby", txtCancel.Text);
                cm.Parameters.AddWithValue("@action", cboAction.Text);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateData(string sql)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if ((cboAction.Text != String.Empty) && (txtCancelQty.Text != String.Empty))
                {
                    if (int.Parse(txtQty.Text) >= int.Parse(txtCancelQty.Text))
                    {

                        SaveCancelOrder();
                        if (cboAction.Text == "Yes")
                        {
                            UpdateData("UPDATE tblproduct SET qty = qty + " + int.Parse(txtCancelQty.Text) + " WHERE pcode = '" + txtPCode.Text + "'");
                        }

                        //UpdateData("UPDATE tblcart SET qty = qty - " + int.Parse(f.txtCancelQty.Text) + " WHERE id LIKE '" + f.txtID.Text + "'");
                        UpdateData("UPDATE tblcart SET qty = qty - " + int.Parse(txtCancelQty.Text) + " WHERE pcode LIKE '" + txtPCode.Text + "'");


                        MessageBox.Show("Return Successfully", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.LoadRecord();

                        if(form1 != null)
                        {
                            form1.GetDashboard();
                        }
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Quantity Invalid", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the form", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
