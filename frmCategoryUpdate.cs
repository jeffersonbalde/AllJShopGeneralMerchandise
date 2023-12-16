using System;
using System.Collections;
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
    public partial class frmCategoryUpdate : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        frmCategoryList frm;
        frmProductList frmpl;

        public frmCategoryUpdate(frmCategoryList form, frmProductList frmPL)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frm = form;
            frmpl = frmPL;
        }


        //copied from update click button from former form in Category Add
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (MessageBox.Show("Are you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            cn.Open();
        //            string query = "UPDATE tblcategory SET category = @category WHERE id LIKE '" + lblID.Text + "'";
        //            cm = new SqlCommand(query, cn);
        //            cm.Parameters.AddWithValue("@category", txtCategory.Text);
        //            cm.ExecuteNonQuery();
        //            cn.Close();
        //            MessageBox.Show("Record has been successfully updated");
        //            flist.LoadCategory();
        //            this.Dispose();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        cn.Close();
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to update this category?", "UPDATE CATEGORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    //string query = "UPDATE tblcategory SET category = @category WHERE id LIKE '" + lblID.Text + "'";
                    string query1 = "UPDATE tblcategory SET category = @category WHERE id LIKE '" + categoryID.Text + "'";
                    cm = new SqlCommand(query1, cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category updated.", "UPDATE CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //frmCategoryList frm = new frmCategoryList();
                    frm.LoadCategory();
                    frmpl.LoadCategory();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCategoryUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click_1(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button2_Click(sender, e);
            }
        }

        private void frmCategoryUpdate_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
