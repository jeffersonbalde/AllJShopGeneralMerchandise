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
        frmCategoryList flist;

        public frmCategoryUpdate()
        {
            InitializeComponent();
        }


        //copied from update click button from former form in Category Add
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    //string query = "UPDATE tblcategory SET category = @category WHERE id LIKE '" + lblID.Text + "'";
                    //cm = new SqlCommand(query, cn);
                    //cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated");
                    flist.LoadCategory();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }







    }
}
