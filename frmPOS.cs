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
    public partial class frmPOS : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr; 
        DBConnection dbcon = new DBConnection();

        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                string query = "SELECT TOP 1 transno FROM tblcart WHERE transno LIKE '" + sdate + "%' ORDER BY id DESC";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransno.Text = sdate + (count + 1);
                }else
                {
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
                dr.Close();
                cn.Close();

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtSearch.Text == String.Empty) { return; }
                else
                {
                    cn.Open();
                    string query = "SELECT * FROM tblproduct WHERE barcode LIKE '" + txtSearch.Text + "'";
                    cm = new SqlCommand(query, cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                     
                    if (dr.HasRows)
                    {
                        frmQty frm = new frmQty(this);
                        frm.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransno.Text);
                        dr.Close();
                        cn.Close();
                        frm.ShowDialog();
                    } else
                    {
                        dr.Close();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void LoadCart()
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                cn.Open();
                string query = "SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tblcart AS c INNER JOIN tblproduct AS p ON c.pcode = p.pcode WHERE transno LIKE '" + lblTransno.Text + "'";
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
                }
                dr.Close();
                cn.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(lblTransno.Text == "000000000000000")
            {
                return;
            }

            frmLookUp frm = new frmLookUp();
            frm.LoadRecords();
            frm.ShowDialog();
        }
    }
}
