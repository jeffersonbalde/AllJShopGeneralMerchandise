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
    public partial class frmDiscount : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmPOS f;

        public frmDiscount(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
            this.KeyPreview = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double discount = Double.Parse(txtPrice.Text) * Double.Parse(txtPercent.Text);
                txtAmount.Text = discount.ToString("#,##0.00");
            }catch(Exception ex)
            {
                txtAmount.Text = "0.00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if(MessageBox.Show("Add discount? Click yes to confirm.", "ALL J GENERAL MERCHANDISE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    string query = "UPDATE tblcart SET disc = @disc WHERE id = @id";
                    cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@disc", Double.Parse(txtAmount.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    f.LoadCart();
                    this.Dispose();
                }

            }catch(Exception ex)
            {
                cn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }    
        }
    }
}
