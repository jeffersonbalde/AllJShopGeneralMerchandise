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
    public partial class frmCategoryList : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmCategoryList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCategory()
        {
            //int i = 0;
            //dataGridView1.Rows.Clear();
            //cn.Open();
            //string query = "SELECT * FROM tblCategory ORDER BY category";
            //cm = new SqlCommand(query, cn);
            //dr = cm.ExecuteReader();

            //while(dr.Read())
            //{
            //    i++;
            //    dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            //}

            //dr.Close();
            //cn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd(this);
        //    frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }



        //deleted former grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            
            //if(colName == "Edit")
            //{
            //    frmCategoryAdd frm = new frmCategoryAdd(this);
            //    frm.txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    frm.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ////    frm.btnSave.Enabled = false;
            //    frm.btnUpdate.Enabled = true;
            //    frm.ShowDialog(); 
            //}else if (colName == "Delete")
            //{
            //    if(MessageBox.Show("Are you sure you want to delete this category","Delete Category",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        cn.Open();
            //        string query = "DELETE tblCategory WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
            //        cm = new SqlCommand(query, cn);
            //        cm.ExecuteNonQuery();
            //        cn.Close();
            //        MessageBox.Show("Record has been successfully deleted!");
            //        LoadCategory();
            //    }
            //}
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd(this);
        //    frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
        {

        }

        private void frmCategoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}