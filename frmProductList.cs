﻿using System;
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
    public partial class frmProductList : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        Form1 form1;
        int totalItems = 0;

        public frmProductList(Form1 frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            form1 = frm;
            frm.GetDashboard();

            this.KeyPreview = true;
            GetTotalItem();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this, form1);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            string query = "SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tblProduct as p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE p.pdesc LIKE '" + txtSearch.Text + "%' ORDER BY p.pdesc";
            string query1 = "SELECT pcode, barcode, pdesc, price, reorder FROM tblproduct WHERE pdesc LIKE '" + txtSearch.Text + "%' ORDER BY pdesc";
            cm = new SqlCommand(query1, cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                frmProduct frm = new frmProduct(this, form1);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.txtPcode.Enabled = false;

                frm.txtPcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtBarcode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtPdesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.txtReorder.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.ShowDialog();

                /*cn.Open();
                string query = "";
                cm = new SqlCommand(query, cn);
                cn.Close();
                */
            }else if (colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this item?","DELETE ITEM", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "DELETE FROM tblproduct WHERE pcode LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                    cm = new SqlCommand(query, cn);
                    cm.ExecuteNonQuery();   
                    cn.Close();
                    LoadRecords();
                    form1.GetDashboard();
                    GetTotalItem();
                    MessageBox.Show("Item has been successfully deleted.");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this, form1);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {

        }


        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this, form1);
            frm.LoadCategoryAddItem();
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonSItem_Click(object sender, EventArgs e)
        {
            frmStockIn frm = new frmStockIn(form1);
            frm.ShowDialog();
        }

        private void ButtonSAdjustment_Click(object sender, EventArgs e)
        {
            StockAdjust frm = new StockAdjust(form1);
            frm.LoadRecords();
            frm.ShowDialog();
        }

        private void frmProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btnAddItem_Click(sender, e);
            }
        }

        public void LoadCategory()
        {
            try
            {
                comboBoxCategory.Items.Clear();
                cn.Open();
                string query = "SELECT * FROM tblCategory";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxCategory.Items.Add(dr["category"].ToString());
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

        public void GetTotalItem()
        {
            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblProduct";
                cm = new SqlCommand(query, cn);
                labelTotalItem.Text = cm.ExecuteScalar().ToString();
                cn.Close();
               
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
