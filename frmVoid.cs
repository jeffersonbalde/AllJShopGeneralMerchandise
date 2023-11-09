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
    public partial class frmVoid : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        frmCancelDetails f;

        public frmVoid(frmCancelDetails frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmVoid_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPass.Text != String.Empty)
                {
                    string user;
                    cn.Open();
                    string query = "SELECT * from tbluser WHERE username = @username AND password = @password";
                    cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@username", txtUser.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    dr = cm.ExecuteReader();

                    dr.Read();
                    if(dr.HasRows)
                    {
                        user = dr["username"].ToString();
                        dr.Close();
                        cn.Close();

                        SaveCancelOrder(user);
                        if(f.cboAction.Text == "Yes")
                        {
                            UpdateData("UPDATE tblproduct SET qty = qty + " + int.Parse(f.txtCancelQty.Text) + " WHERE pcode = '" + f.txtPCode.Text + "'");
                        }

                        UpdateData("UPDATE tblcart SET qty = qty - " + int.Parse(f.txtCancelQty.Text) + " WHERE id LIKE '" + f.txtID.Text + "'");

                        MessageBox.Show("Void Successfully", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        f.RefreshList();    
                        f.Dispose();
                    }
                    dr.Close();
                    cn.Close();
                }
                //else
                //{
                //    MessageBox.Show("Username and password do not match", "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                string query1 = "INSERT INTO tblcancel (transno, pcode, price, qty, sdate, voidby, cancelledby, reason, action) VALUES (@transno, @pcode, @price, @qty, @sdate, @voidby, @cancelledby, @reason, @action)";
                cm = new SqlCommand(query1, cn);
                cm.Parameters.AddWithValue("@transno", f.txtTransnoNo.Text);
                cm.Parameters.AddWithValue("@pcode", f.txtPCode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(f.txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(f.txtCancelQty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", f.txtCancel.Text);
                cm.Parameters.AddWithValue("@reason", f.txtReason.Text);
                cm.Parameters.AddWithValue("@action", f.cboAction.Text);
                cm.ExecuteNonQuery();
                cn.Close();

            }catch(Exception ex)
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

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J SHOP GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
