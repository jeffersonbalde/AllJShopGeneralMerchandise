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
using System.Data.Common;

namespace OOP_System
{
    public partial class frmCategory : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmCategoryList flist;
        public frmCategory(frmCategoryList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear();
            txtCategory.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you want to update this category?","Update Category",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "UPDATE tblcategory SET category = @category WHERE id LIKE '" + lblID.Text + "'";
                    cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated");
                    flist.LoadCategory();
                    this.Dispose();
                }

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        public bool IsCategoryDuplicate()
        {
            using (SqlConnection cn = new SqlConnection(dbcon.MyConnection())) 
            {
                cn.Open();
                string query1 = "SELECT category FROM tblcategory";
                using (SqlCommand cm = new SqlCommand(query1, cn))
                {
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (txtCategory.Text == dr["category"].ToString())
                            {
                                MessageBox.Show("Category already exists", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //handle empty input
            if (txtCategory.Text == string.Empty) { MessageBox.Show("Please enter category name", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCategory.Focus(); return; }

            if (!IsCategoryDuplicate())
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        string query = "INSERT INTO tblCategory(category) VALUES(@category)";
                        cm = new SqlCommand(query, cn);
                        cm.Parameters.AddWithValue("@category", txtCategory.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Category has been successfully saved");
                        Clear();
                        flist.LoadCategory();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //try
            //{
            //    if(MessageBox.Show("Are you sure you want to save this category?","Saving Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        cn.Open();
            //        string query = "INSERT INTO tblCategory(category) VALUES(@category)";
            //        cm = new SqlCommand(query, cn); 
            //        cm.Parameters.AddWithValue("@category", txtCategory.Text);
            //        cm.ExecuteNonQuery();
            //        cn.Close();

            //        MessageBox.Show("Category has been successfully saved");
            //        Clear();
            //        flist.LoadCategory();
            //    }
            //}catch(Exception ex)
            //{
            //    cn.Close();
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
