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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();

        DBConnection dbcon = new DBConnection();
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            //cn.Open();
            MessageBox.Show("Connected");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBrandList frm = new frmBrandList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList frm = new frmCategoryList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadCategory();
            frm.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            frmProductList frm = new frmProductList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadRecords();
            frm.Show();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStockIn frm = new frmStockIn();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmUserAccount frm = new frmUserAccount();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
