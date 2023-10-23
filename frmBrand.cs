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
using System.Collections;

namespace OOP_System
{
    public partial class frmBrand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmBrandList frmlist;

        public frmBrand(frmBrandList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        //public bool IsBrandDuplicate()
        //{
        //    cn.Open();
        //    string query1 = "SELECT brand FROM tblbrand";
        //    cm = new SqlCommand(query1, cn);
        //    dr = cm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        if (txtBrand.Text == dr["brand"].ToString())
        //        {
        //            MessageBox.Show("Brand already exist", "Duplicate Brand", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return true;
        //        }
        //    }
        //    dr.Close();
        //    cn.Close();
        //    return false;
        //}

        public bool IsBrandDuplicate()
        {
            using (SqlConnection cn = new SqlConnection(dbcon.MyConnection())) 
            {
                cn.Open();
                string query1 = "SELECT brand FROM tblbrand";
                using (SqlCommand cm = new SqlCommand(query1, cn))
                {
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (txtBrand.Text == dr["brand"].ToString())
                            {
                                MessageBox.Show("Brand already exists", "Duplicate Brand", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //try
            //{
                //handle empty input
                if (txtBrand.Text == string.Empty) { MessageBox.Show("Please enter brand name", "Add Brand", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtBrand.Focus(); return; }

                if (!IsBrandDuplicate())
                {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        string query = "INSERT INTo tblBrand(Brand)VALUEs(@brand)";
                        cm = new SqlCommand(query, cn);
                        cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully saved.");
                        Clear();

                        frmlist.LoadRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }

                //if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    cn.Open();
                //    string query = "INSERT INTo tblBrand(Brand)VALUEs(@brand)";
                //    cm = new SqlCommand(query, cn);
                //    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                //    cm.ExecuteNonQuery();
                //    cn.Close();
                //    MessageBox.Show("Record has been successfully saved.");
                //    Clear();

                //    frmlist.LoadRecords();
                //}
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to update this brand?", "Update Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "UPDATE tblBrand SET brand = @brand WHERE id LIKE '" + lblID.Text + "'";
                    cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully updated.");
                    Clear();
                    frmlist.LoadRecords();
                    this.Dispose();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBrand.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
