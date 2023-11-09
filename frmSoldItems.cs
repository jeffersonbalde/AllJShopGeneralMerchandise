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
    public partial class frmSoldItems : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public string suser;

        public frmSoldItems()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            LoadRecord();
            LoadCashier();
        }

        public void LoadCashier()
        {
            cboCashier.Items.Clear();
            cboCashier.Items.Add("All Cashier");
            cn.Open();  
            string query = "SELECT name from tblUser WHERE role = 'Cashier'";
            cm = new SqlCommand(query, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCashier.Items.Add(dr["name"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecord()
        {
            try
            {
                int i = 0;
                double _total = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                if(cboCashier.Text == "All Cashier")
                {
                    string query1 = "SELECT c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tblCart as c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "'";
                    cm = new SqlCommand(query1, cn);
                }else
                {
                    string query = "SELECT c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tblCart as c INNER JOIN tblProduct as p ON c.pcode = p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dt1.Value.ToString("yyyy-MM-dd") + "' AND '" + dt2.Value.ToString("yyyy-MM-dd") + "' AND cashier LIKE '" + cboCashier.Text + "'";
                    cm = new SqlCommand(query, cn);
                }
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i += 1;
                    _total += double.Parse(dr["total"].ToString()); 
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = _total.ToString("#,##0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if(colName == "colCancel")
            {
                frmCancelDetails f = new frmCancelDetails(this);
                f.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtTransnoNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtPCode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.txtDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                f.txtCancel.Text = suser;
                    
                f.ShowDialog(); 
            }
        }

        private void frmSoldItems_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportSold frm = new frmReportSold(this);
            frm.LoadReport();
            frm.ShowDialog();
        }

        private void cboCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
