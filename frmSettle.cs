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
    public partial class frmSettle : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmPOS fpos;

        public frmSettle(frmPOS fp)
        {   
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = fp;
            this.KeyPreview = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = double.Parse(txtSale.Text);
                double cash = double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");

            }catch(Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

        public void UpdateQuantity()
        {
            for (int i = 0; i < fpos.dataGridView1.Rows.Count; i++)
            {
                cn.Open();
                string query = "UPDATE tblproduct SET qty = qty - " + int.Parse(fpos.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode = '" + fpos.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'";
                cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();
                cn.Close();

                cn.Open();
                string query1 = "UPDATE tblcart SET status = 'Sold' WHERE id = '" + fpos.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'";
                cm = new SqlCommand(query1, cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                
                if((double.Parse(txtChange.Text) < 0) || (txtCash.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient Amount!", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else
                {
                    UpdateQuantity();

                    frmReceipt frm = new frmReceipt(fpos);
                    frm.LoadReport(txtCash.Text, txtChange.Text);
                    
                    frm.ShowDialog();

                    MessageBox.Show("Payment successfully saved!", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fpos.GetTransNo();
                    fpos.LoadCart();
                    fpos.LoadRecords();
                    this.Dispose();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Insufficient Amount!", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmSettle_Load(object sender, EventArgs e)
        {
            txtCash.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSettle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCash.Text = button4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int length = txtCash.Text.Length;
            txtCash.Text = txtCash.Text.Substring(0, length - 1);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCash.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCash.Text = button11.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCash.Text = button5.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            txtCash.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCash.Text = button9.Text;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            txtCash.Text = button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtCash.Text = button13.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCash.Text = button6.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            txtCash.Text = button7.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtCash.Text = button15.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtCash.Text = button14.Text;
        }
    }
}
