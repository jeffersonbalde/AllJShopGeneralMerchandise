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
    public partial class frmProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmProductList flist;

        public frmProduct(frmProductList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        //public void LoadCategory()
        //{
        //    cboCategory.Items.Clear();
        //    cn.Open();
        //    string query = "SELECT category FROM tblcategory";
        //    cm = new SqlCommand(query, cn);
        //    dr = cm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        cboCategory.Items.Add(dr[0].ToString());
        //    }
        //    dr.Close();
        //    cn.Close();
        //}

        //public void LoadBrand()
        //{
        //    cboBrand.Items.Clear();
        //    cn.Open();
        //    string query = "SELECT brand FROM tblbrand";
        //    cm = new SqlCommand(query, cn);
        //    dr = cm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        cboBrand.Items.Add(dr[0].ToString());
        //    }
        //    dr.Close();
        //    cn.Close();
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if(MessageBox.Show("Are you sure you want to save this item?","SAVE ITEM",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //string bid = ""; 
                    //string cid = "";

                    ////brand ID
                    //cn.Open();
                    //string query = "SELECT id FROM tblBrand WHERE brand like '" + cboBrand.Text + "'";
                    //cm = new SqlCommand(query, cn);
                    //dr = cm.ExecuteReader();
                    //dr.Read();
                    //if (dr.HasRows)
                    //{
                    //    bid = dr[0].ToString();
                    //}
                    //dr.Close();
                    //cn.Close();

                    ////category ID
                    //cn.Open();
                    //string query1 = "SELECT id FROM tblCategory WHERE category like '" + cboCategory.Text + "'";
                    //cm = new SqlCommand(query1, cn);
                    //dr = cm.ExecuteReader();
                    //dr.Read();
                    //if (dr.HasRows)
                    //{
                    //    cid = dr[0].ToString();
                    //}
                    //dr.Close();
                    //cn.Close();

                    cn.Open();
                    string query2 = "INSERT INTO tblProduct (barcode, pdesc, price, reorder) VALUES(@barcode, @pdesc, @price, @reorder)";
                    cm = new SqlCommand(query2, cn);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Item has been successfully saved.");
                    Clear();
                    flist.LoadRecords();
                }

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtPcode.Clear();
            txtPdesc.Clear();
            txtBarcode.Clear();
            txtPrice.Clear();
            txtPcode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to update this item?", "UPDATE ITEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //string bid = "";
                    //string cid = "";

                    ////brand ID
                    //cn.Open();
                    //string query = "SELECT id FROM tblBrand WHERE brand like '" + cboBrand.Text + "'";
                    //cm = new SqlCommand(query, cn);
                    //dr = cm.ExecuteReader();
                    //dr.Read();
                    //if (dr.HasRows)
                    //{
                    //    bid = dr[0].ToString();
                    //}
                    //dr.Close();
                    //cn.Close();

                    ////category ID
                    //cn.Open();
                    //string query1 = "SELECT id FROM tblCategory WHERE category like '" + cboCategory.Text + "'";
                    //cm = new SqlCommand(query1, cn);
                    //dr = cm.ExecuteReader();
                    //dr.Read();
                    //if (dr.HasRows)
                    //{
                    //    cid = dr[0].ToString();
                    //}
                    //dr.Close();
                    //cn.Close();

                    cn.Open();
                    string query2 = "UPDATE tblProduct SET barcode = @barcode, pdesc=@pdesc, price=@price, reorder=@reorder WHERE pcode LIKE @pcode";
                    cm = new SqlCommand(query2, cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Item has been successfully updated.");
                    Clear();
                    flist.LoadRecords();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only numbers
            if(e.KeyChar == 46)
            {
                //accept . character
            }else if(e.KeyChar == 8)
            {
                //accept backspace
            }else if((e.KeyChar < 48) || (e.KeyChar > 57)) //accept code 48-57 between 0-9
            {
                e.Handled = true;
            }
        }

        private void txtPdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
